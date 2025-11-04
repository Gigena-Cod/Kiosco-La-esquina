using Kiosco_La_esquina.domain.models;
using Kiosco_La_esquina.domain.services;


namespace Kiosco_La_esquina.infrastructure.features.Products.ProductCreationFlow
{
    public partial class ProductCreationFlow : Form
    {
        private readonly SupplierService _supplierService;
        private readonly ProductService _productService;

        public ProductCreationFlow()
        {
            InitializeComponent();
            _supplierService = new SupplierService();
            _productService = new ProductService();
        }

        private void ProductCreationFlow_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadSuppliers();
        }

        // 🔹 Cargar categorías fijas de productos típicos de almacén
        private void LoadCategories()
        {
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

        // 🔹 Cargar proveedores desde el servicio
        private void LoadSuppliers()
        {
            try
            {
                var suppliers = _supplierService.GetAllSuppliers();

                supplierComboBox.DataSource = suppliers;
                supplierComboBox.DisplayMember = "Name";   // nombre visible
                supplierComboBox.ValueMember = "Id";       // valor interno
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proveedores: {ex.Message}");
            }
        }

        // 🔹 Crear producto
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nameTextBox.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre de producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (categoryComboBox.SelectedItem == null || supplierComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una categoría y un proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedSupplier = (Supplier)supplierComboBox.SelectedItem;

                var product = new Product
                {
                    Name = nameTextBox.Text.Trim(),
                    Category = categoryComboBox.SelectedItem.ToString(),
                    SupplierID = selectedSupplier.ID,
                    Price = decimal.TryParse(priceNumericUpDown.Text, out var price) ? price : 0,
                    Stock = int.TryParse(stockNumericUpDown.Text, out var stock) ? stock : 0,
                    Description = descriptionTextBox.Text.Trim()
                };

                _productService.CreateProduct(product);

                MessageBox.Show("Producto creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
