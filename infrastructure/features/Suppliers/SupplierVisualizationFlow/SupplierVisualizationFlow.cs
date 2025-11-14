using Kiosco_La_esquina.domain.services; 

namespace Kiosco_La_esquina.infrastructure.features.Suppliers.SupplierVisualizationFlow
{
    public partial class SupplierVisualizationFlow : Form
    {
        private SupplierService _supplierService;
        // Cambia la declaración de la lista de proveedores para usar el tipo correcto con el espacio de nombres completo
        private List<Kiosco_La_esquina.domain.models.Supplier> _suppliers;

        public SupplierVisualizationFlow()
        {
            InitializeComponent();
            _supplierService = new SupplierService();
        }

        private void SupplierVisualizationFlow_Load(object sender, EventArgs e)
        {
            // Configurar el DataGridView
            ConfigureDataGridView();
            // Cargar todos los proveedores
            LoadSuppliers();
        }

        private void ConfigureDataGridView()
        {
            dataGridViewSuppliers.AutoGenerateColumns = false;
            dataGridViewSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSuppliers.MultiSelect = false;
            dataGridViewSuppliers.AllowUserToAddRows = false;
            dataGridViewSuppliers.ReadOnly = true;
            dataGridViewSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Limpiar columnas si hay algo
            dataGridViewSuppliers.Columns.Clear();

            // Crear columnas
            dataGridViewSuppliers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 50
            });

            dataGridViewSuppliers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "Nombre",
                DataPropertyName = "Name",
                Width = 200
            });

            dataGridViewSuppliers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Contact_Name",
                HeaderText = "Contacto",
                DataPropertyName = "Contact_Name",
                Width = 150
            });


            dataGridViewSuppliers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Address",
                HeaderText = "Dirección",
                DataPropertyName = "Address",
                Width = 150
            });

            dataGridViewSuppliers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Phone",
                HeaderText = "Teléfono",
                DataPropertyName = "Phone",
                Width = 100
            });
        }

        private void LoadSuppliers()
        {
            _suppliers = _supplierService.GetAllSuppliers(); // Trae todos los proveedores
            dataGridViewSuppliers.DataSource = null;
            dataGridViewSuppliers.DataSource = _suppliers;
        }


        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string query = searchTextBox.Text.ToLower();
            var filtered = _suppliers.FindAll(s =>
                s.Name.ToLower().Contains(query)
            );
            dataGridViewSuppliers.DataSource = null;
            dataGridViewSuppliers.DataSource = filtered;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonExportSupplier_Click(object sender, EventArgs e)
        {
            if (_suppliers == null || _suppliers.Count == 0)
            {
                MessageBox.Show("No hay proveedores para exportar.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Guardar lista de proveedores";
                saveFileDialog.Filter = "Archivos CSV (*.csv)|*.csv|Archivos de texto (*.txt)|*.txt";
                saveFileDialog.DefaultExt = "csv";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                        {
                            // CABECERA
                            writer.WriteLine("ID;Nombre;NombreContacto;Telefono;Direccion");

                            // FILAS
                            foreach (var s in _suppliers)
                            {
                                writer.WriteLine(
                                    $"{s.ID};" +
                                    $"{s.Name};" +
                                    $"{s.Contact_Name};" +
                                    $"{s.Phone};" +
                                    $"{s.Address}"
                                );
                            }
                        }

                        MessageBox.Show("Proveedores exportados correctamente.", "Éxito",
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
