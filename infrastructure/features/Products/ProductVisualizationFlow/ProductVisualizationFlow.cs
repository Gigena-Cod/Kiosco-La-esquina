using Kiosco_La_esquina.domain.models;
using Kiosco_La_esquina.domain.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kiosco_La_esquina.infrastructure.features.Products.ProductVisualizationFlow
{
    public partial class ProductVisualizationFlow : Form
    {
        private ProductService _productService;
        private List<Kiosco_La_esquina.domain.models.Product> _products;

        public ProductVisualizationFlow()
        {
            InitializeComponent();
            _productService = new ProductService();
        }

        private void ProductVisualizationFlow_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            LoadProducts();
        }

        private void ConfigureDataGridView()
        {
            dataGridViewProducts.AutoGenerateColumns = false;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.MultiSelect = false;
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Limpiar columnas previas
            dataGridViewProducts.Columns.Clear();

            // ID
            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ID",
                HeaderText = "ID",
                DataPropertyName = "ID",
                Width = 50
            });

            // Nombre
            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "Nombre del producto",
                DataPropertyName = "Name",
                Width = 200
            });

            // Descripción
            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Description",
                HeaderText = "Descripción",
                DataPropertyName = "Description",
                Width = 200
            });

            // Precio
            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "Precio ($)",
                DataPropertyName = "Price",
                Width = 80
            });

            // Stock
            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Stock",
                HeaderText = "Stock",
                DataPropertyName = "Stock",
                Width = 80
            });

            // ID proveedor
            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SupplierId",
                HeaderText = "ID Proveedor",
                DataPropertyName = "SupplierId",
                Width = 100
            });
        }

        private void LoadProducts()
        {
            _products = _productService.GetAllProducts();
            dataGridViewProducts.DataSource = null;
            dataGridViewProducts.DataSource = _products;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string query = searchTextBox.Text.ToLower();

            var filtered = _products.FindAll(p =>
                p.Name.ToLower().Contains(query) ||
                p.Description.ToLower().Contains(query)
            );

            dataGridViewProducts.DataSource = null;
            dataGridViewProducts.DataSource = filtered;
        }

        private void buttonExportProducts_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exportar productos aún no implementado.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonExportProducts_Click_1(object sender, EventArgs e)
        {
            if (_products == null || _products.Count == 0)
            {
                MessageBox.Show("No hay productos para exportar.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Guardar lista de productos";
                saveFileDialog.Filter = "Archivos CSV (*.csv)|*.csv|Archivos de texto (*.txt)|*.txt";
                saveFileDialog.DefaultExt = "csv";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                        {
                            // Cabecera
                            writer.WriteLine("ID;Nombre;Descripción;Precio;Stock;Categoría;ID Proveedor");

                            // Filas
                            foreach (var p in _products)
                            {
                                writer.WriteLine(
                                    $"{p.ID};" +
                                    $"{p.Name};" +
                                    $"{p.Description};" +
                                    $"{p.Price};" +
                                    $"{p.Stock};" +
                                    $"{p.Category};" +
                                    $"{p.SupplierID}"
                                );
                            }
                        }

                        MessageBox.Show("Productos exportados correctamente.", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
