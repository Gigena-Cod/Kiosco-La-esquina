using Kiosco_La_esquina.domain.models;
using Kiosco_La_esquina.domain.repository;
using Kiosco_La_esquina.domain.services;
using System.Data;
using System.Text;

namespace Kiosco_La_esquina.infrastructure.features.Employees.EmployeeVisualisationFlow
{
    public partial class EmployeeVisualisationFlow : Form
    {

        private List<Employee> employees = new List<Employee>();
        private Repository _repository;

        public EmployeeVisualisationFlow()
        {
            InitializeComponent();
            _repository = new Repository();
            ConfigureDataGridView();
            LoadEmployees();
        }

        private void EmployeeVisualisationFlow_Load(object sender, EventArgs e)
        {

        }


        private void ConfigureDataGridView()
        {
            // Evitar fila vacía al final
            dataGridViewEmployees.AllowUserToAddRows = false;

            // No permitir que el usuario edite directamente
            dataGridViewEmployees.ReadOnly = true;

            // Evitar autogenerar columnas si vas a configurarlas manualmente
            dataGridViewEmployees.AutoGenerateColumns = false;

            // Limpiar columnas anteriores
            dataGridViewEmployees.Columns.Clear();

            // Columnas
            dataGridViewEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre",
                DataPropertyName = "FirstName",
                Width = 100
            });

            dataGridViewEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Apellido",
                DataPropertyName = "LastName",
                Width = 100
            });


            dataGridViewEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Dni",
                DataPropertyName = "Identifier",
                Width = 100
            });

            dataGridViewEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Email",
                DataPropertyName = "Email",
                Width = 150
            });

            dataGridViewEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Cargo",
                DataPropertyName = "Role",
                Width = 100
            });

            dataGridViewEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Salario",
                DataPropertyName = "Salary",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } // Formato moneda
            });

            dataGridViewEmployees.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Fecha de ingreso",
                DataPropertyName = "HireDate",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            // Fuente de datos
            dataGridViewEmployees.DataSource = employees; // Puede ser BindingList<Employee>
        }



        private void LoadEmployees()
        {
            EmployeeService service = new EmployeeService();
            employees = service.GetAllEmployees();

            dataGridViewEmployees.DataSource = null;
            dataGridViewEmployees.DataSource = employees;
            dataGridViewEmployees.AutoResizeColumns();
        }

        private void buttonExportEmployeess_Click(object sender, EventArgs e)
        {
            if (employees == null || employees.Count == 0)
            {
                MessageBox.Show("No hay empleados para exportar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Guardar lista de empleados";
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
                            writer.WriteLine("Nombre;Apellido;DNI;Email;Cargo;Salario;FechaIngreso");

                            // Filas
                            foreach (var emp in employees)
                            {
                                writer.WriteLine($"{emp.FirstName};{emp.LastName};{emp.Identifier};{emp.Email};{emp.Role};{emp.Salary};{emp.HireDate:dd/MM/yyyy}");
                            }
                        }

                        MessageBox.Show("Empleados exportados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                // Si no hay texto, mostrar todos los empleados
                dataGridViewEmployees.DataSource = employees;
            }
            else
            {
                // Filtrar empleados por coincidencia parcial en Nombre, Apellido, DNI, Email o Cargo
                var filtered = employees.Where(emp =>
                    emp.FirstName.ToLower().Contains(searchText) ||
                    emp.LastName.ToLower().Contains(searchText) ||
                    emp.Identifier.ToString().Contains(searchText) ||
                    emp.Email.ToLower().Contains(searchText) ||
                    emp.Role.ToLower().Contains(searchText)
                ).ToList();

                dataGridViewEmployees.DataSource = filtered;
            }

            dataGridViewEmployees.Refresh();
        }

    }
}
