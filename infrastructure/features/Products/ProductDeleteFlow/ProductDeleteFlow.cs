using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Kiosco_La_esquina.domain.models;
using Kiosco_La_esquina.domain.services;

namespace Kiosco_La_esquina.infrastructure.features.Products.ProductDeleteFlow
{
    public partial class ProductDeleteFlow : Form
    {
        private readonly ProductService _productService = new();
        private readonly SupplierService _supplierService = new();
        private List<Product> _products = new();
        private List<Supplier> _suppliers = new();

        public ProductDeleteFlow()
        {
            InitializeComponent();
            ConfigureControls();

            comboBoxProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProduct.SelectedIndexChanged += comboBoxProduct_SelectedIndexChanged;
            buttonDelete.Click += buttonDelete_Click;

            SetInputsEnabled(false); // solo visualización
        }

        private void ProductDeleteFlow_Load(object? sender, EventArgs e)
        {
            LoadSuppliers();
            LoadProductsCombo();
            comboBoxProduct.SelectedIndex = -1; // sin selección al abrir
            ClearDetail();
        }

        private void ConfigureControls()
        {
            // quitar negrita
            nameTextBox.Font = new System.Drawing.Font(nameTextBox.Font, System.Drawing.FontStyle.Regular);
            descriptionTextBox.Font = new System.Drawing.Font(descriptionTextBox.Font, System.Drawing.FontStyle.Regular);

            // NumericUpDowns
            priceNumericUpDown.Minimum = 0;
            priceNumericUpDown.Maximum = 1_000_000m;
            priceNumericUpDown.DecimalPlaces = 2;
            priceNumericUpDown.Increment = 1;
            priceNumericUpDown.ThousandsSeparator = true;

            stockNumericUpDown.Minimum = 0;
            stockNumericUpDown.Maximum = 1_000_000m;
        }

        private void LoadSuppliers()
        {
            _suppliers = _supplierService.GetAllSuppliers() ?? new List<Supplier>();
        }

        private void LoadProductsCombo()
        {
            _products = _productService.GetAllProducts() ?? new List<Product>();

            comboBoxProduct.DataSource = null;
            comboBoxProduct.DisplayMember = nameof(Product.Name);
            comboBoxProduct.ValueMember = nameof(Product.ID);
            comboBoxProduct.DataSource = _products;

            ClearDetail();
        }

        private void comboBoxProduct_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (comboBoxProduct.SelectedItem is not Product p) { ClearDetail(); return; }

            nameTextBox.Text = p.Name ?? string.Empty;
            descriptionTextBox.Text = p.Description ?? string.Empty;

            priceNumericUpDown.Value = Clamp(priceNumericUpDown, p.Price);
            stockNumericUpDown.Value = Clamp(stockNumericUpDown, p.Stock);

            categoryComboBox.Items.Clear();
            categoryComboBox.Items.Add(p.Category ?? "");
            categoryComboBox.SelectedIndex = 0;

            var supplier = _suppliers.FirstOrDefault(s => s.ID == p.SupplierID);
            supplierComboBox.Items.Clear();
            supplierComboBox.Items.Add(supplier != null ? supplier.Name : p.SupplierID.ToString());
            supplierComboBox.SelectedIndex = 0;
        }

        private void buttonDelete_Click(object? sender, EventArgs e)
        {
            if (comboBoxProduct.SelectedItem is not Product p)
            {
                MessageBox.Show("Seleccione un producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var ok = MessageBox.Show(
                $"¿Eliminar definitivamente \"{p.Name}\" (ID {p.ID})?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            ) == DialogResult.Yes;

            if (!ok) return;

            try
            {
                var deleted = _productService.DeleteProduct(p.ID);
                if (deleted)
                {
                    MessageBox.Show("Producto eliminado.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProductsCombo();
                    comboBoxProduct.SelectedIndex = -1;
                    ClearDetail();
                    return;
                }
               
                
                MessageBox.Show("No se eliminó el producto.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetInputsEnabled(bool _)
        {
            nameTextBox.Enabled = false;
            descriptionTextBox.Enabled = false;
            priceNumericUpDown.Enabled = false;
            stockNumericUpDown.Enabled = false;
            categoryComboBox.Enabled = false;
            supplierComboBox.Enabled = false;
        }

        private void ClearDetail()
        {
            nameTextBox.Clear();
            descriptionTextBox.Clear();
            priceNumericUpDown.Value = 0;
            stockNumericUpDown.Value = 0;
            categoryComboBox.Items.Clear();
            supplierComboBox.Items.Clear();
        }

        private static decimal Clamp(NumericUpDown nud, decimal v) =>
            Math.Min(nud.Maximum, Math.Max(nud.Minimum, v));

        private static decimal Clamp(NumericUpDown nud, int v) =>
            Math.Min(nud.Maximum, Math.Max(nud.Minimum, v));
    }
}
