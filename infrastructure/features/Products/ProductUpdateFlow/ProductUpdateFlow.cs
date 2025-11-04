using Kiosco_La_esquina.domain.models;
using Kiosco_La_esquina.domain.services;

namespace Kiosco_La_esquina.infrastructure.features.Products.ProductUpdateFlow
{
    public partial class ProductUpdateFlow : Form
    {
        private Product currentProduct;
        private ProductService _productService;
        private SupplierService _supplierService;
        private bool changesMade = false;
        private bool isLoading = false;

        public ProductUpdateFlow()
        {
            InitializeComponent();
            _productService = new ProductService();
            _supplierService = new SupplierService();

            // Rango y formato numéricos
            priceNumericUpDown.Minimum = 0m;
            priceNumericUpDown.Maximum = 1_000_000m;
            priceNumericUpDown.DecimalPlaces = 2;
            priceNumericUpDown.Increment = 0.50m;

            stockNumericUpDown.Minimum = 0m;
            stockNumericUpDown.Maximum = 1_000_000m;
            stockNumericUpDown.DecimalPlaces = 0;
            stockNumericUpDown.Increment = 1m;

            LoadCategoriesComboBox();
            LoadSuppliersComboBox();
            LoadProductsComboBox();

            // Eventos
            nameTextBox.TextChanged += OnFieldChanged;
            descriptionTextBox.TextChanged += OnFieldChanged;
            priceNumericUpDown.ValueChanged += OnFieldChanged;
            stockNumericUpDown.ValueChanged += OnFieldChanged;
            categoryComboBox.SelectedIndexChanged += OnFieldChanged;
            supplierComboBox.SelectedIndexChanged += OnFieldChanged;

            comboBoxProduct.SelectedIndexChanged += comboBoxProduct_SelectedIndexChanged;

            buttonUpdate.Enabled = false;
        }


        private void LoadProductsComboBox()
        {
            isLoading = true;
            try
            {
                comboBoxProduct.SelectedIndexChanged -= comboBoxProduct_SelectedIndexChanged;

                var products = _productService.GetAllProducts();
                comboBoxProduct.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxProduct.DataSource = null;
                comboBoxProduct.DisplayMember = "Name";
                comboBoxProduct.ValueMember = "ID";
                comboBoxProduct.DataSource = products;
                comboBoxProduct.SelectedIndex = -1;
            }
            finally
            {
                comboBoxProduct.SelectedIndexChanged += comboBoxProduct_SelectedIndexChanged;
                isLoading = false;
            }
        }


        // 🔹 Cargar categorías fijas
        private void LoadCategoriesComboBox()
        {
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            var categories = new List<string>
            {
                "Alimentos secos",
                "Bebidas",
                "Lácteos",
                "Fiambres",
                "Panadería",
                "Limpieza",
                "Higiene personal",
                "Snacks",
                "Congelados",
                "Verduras y frutas"
            };
            categoryComboBox.DataSource = categories;
        }

        // 🔹 Cargar proveedores
        private void LoadSuppliersComboBox()
        {
            try
            {
                isLoading = true;
                var suppliers = _supplierService.GetAllSuppliers();
                supplierComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                supplierComboBox.DataSource = null;
                supplierComboBox.DisplayMember = "Name";
                supplierComboBox.ValueMember = "ID";
                supplierComboBox.DataSource = suppliers;
                supplierComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proveedores: {ex.Message}");
            }
            finally
            {
                isLoading = false;
            }
        }

        // 🔹 Evento cuando cambia un campo → habilitar botón
        private void OnFieldChanged(object sender, EventArgs e)
        {
            if (isLoading) return;
            changesMade = true;
            buttonUpdate.Enabled = true;
        }

        // 🔹 Al seleccionar un producto en el combo
        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading || comboBoxProduct.SelectedIndex == -1) return;

            currentProduct = comboBoxProduct.SelectedItem as Product;
            if (currentProduct == null) return;

            isLoading = true;
            try
            {
                nameTextBox.Text = currentProduct.Name ?? string.Empty;
                descriptionTextBox.Text = currentProduct.Description ?? string.Empty;

                // clamp para evitar ArgumentOutOfRange
                decimal price = currentProduct.Price;               // Product.Price debe ser decimal
                decimal stock = currentProduct.Stock;               // cast si es int: (decimal)currentProduct.Stock

                priceNumericUpDown.Value = Math.Min(priceNumericUpDown.Maximum,
                                             Math.Max(priceNumericUpDown.Minimum, price));
                stockNumericUpDown.Value = Math.Min(stockNumericUpDown.Maximum,
                                             Math.Max(stockNumericUpDown.Minimum, stock));

                // Categoría: seleccionar si existe, si no la primera
                int catIndex = categoryComboBox.Items.IndexOf(currentProduct.Category);
                categoryComboBox.SelectedIndex = catIndex >= 0 ? catIndex : 0;

                // Proveedor: usar SelectedValue
                supplierComboBox.SelectedValue = currentProduct.SupplierID;

                changesMade = false;
                buttonUpdate.Enabled = false;
            }
            finally
            {
                isLoading = false;
            }
        }

        // 🔹 Botón “Actualizar producto”
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (currentProduct == null)
            {
                MessageBox.Show("Seleccione un producto para actualizar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!changesMade)
            {
                MessageBox.Show("No se han realizado cambios.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                currentProduct.Name = nameTextBox.Text.Trim();
                currentProduct.Description = descriptionTextBox.Text.Trim();
                currentProduct.Price = priceNumericUpDown.Value;            // decimal
                currentProduct.Stock = (int)stockNumericUpDown.Value;
                currentProduct.Category = categoryComboBox.SelectedItem?.ToString() ?? "";
                currentProduct.SupplierID = (int)(supplierComboBox.SelectedValue ?? 0);

                bool success = _productService.UpdateProduct(currentProduct);
                if (success)
                {
                    MessageBox.Show("Producto actualizado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonUpdate.Enabled = false;
                    changesMade = false;
                    LoadProductsComboBox();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el producto.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar producto: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🔹 Botón “Cancelar”
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
