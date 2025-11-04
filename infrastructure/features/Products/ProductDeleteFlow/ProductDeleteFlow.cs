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
            comboBoxProduct.SelectedIndex = -1; // sin selección
            buttonDelete.Enabled = false;       // deshabilitado al iniciar
            ClearDetail();
        }

        private void ConfigureControls()
        {
            nameTextBox.Font = new System.Drawing.Font(nameTextBox.Font, System.Drawing.FontStyle.Regular);
            descriptionTextBox.Font = new System.Drawing.Font(descriptionTextBox.Font, System.Drawing.FontStyle.Regular);

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

        private bool _deleting;

        private void comboBoxProduct_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (comboBoxProduct.SelectedItem is not Product p)
            {
                ClearDetail();
                buttonDelete.Enabled = false;
                return;
            }

            buttonDelete.Enabled = true;

            nameTextBox.Text = p.Name ?? "";
            descriptionTextBox.Text = p.Description ?? "";
            priceNumericUpDown.Value = Clamp(priceNumericUpDown, p.Price);
            stockNumericUpDown.Value = Clamp(stockNumericUpDown, p.Stock);

            categoryComboBox.Items.Clear();
            categoryComboBox.Items.Add(p.Category ?? "");
            categoryComboBox.SelectedIndex = 0;

            var supplier = _suppliers.FirstOrDefault(s => s.ID == p.SupplierID);
            supplierComboBox.Items.Clear();
            supplierComboBox.Items.Add(supplier?.Name ?? p.SupplierID.ToString());
            supplierComboBox.SelectedIndex = 0;
        }

        private void buttonDelete_Click(object? sender, EventArgs e)
        {
            if (_deleting) return; // evita reentradas
            if (comboBoxProduct.SelectedItem is not Product p) return; // nada seleccionado

            _deleting = true;
            buttonDelete.Enabled = false; // bloquea doble clic

            var id = p.ID;
            var name = p.Name ?? "(sin nombre)";

            var ok = MessageBox.Show(
                $"¿Eliminar definitivamente \"{name}\" (ID {id})?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            ) == DialogResult.Yes;

            if (!ok)
            {
                // re-habilita si sigue habiendo selección
                buttonDelete.Enabled = comboBoxProduct.SelectedIndex >= 0;
                _deleting = false;
                return;
            }

            try
            {
                var deleted = _productService.DeleteProduct(id);
                if (deleted)
                {
                    MessageBox.Show("Producto eliminado.", "OK",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProductsCombo();
                    comboBoxProduct.SelectedIndex = -1;
                    ClearDetail();
                    // queda deshabilitado hasta nueva selección
                }
                else
                {
                    MessageBox.Show("No se eliminó el producto.", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonDelete.Enabled = comboBoxProduct.SelectedIndex >= 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonDelete.Enabled = comboBoxProduct.SelectedIndex >= 0;
            }
            finally
            {
                _deleting = false;
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
