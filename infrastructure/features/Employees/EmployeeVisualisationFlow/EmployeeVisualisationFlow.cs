using Kiosco_La_esquina.domain.models;

namespace Kiosco_La_esquina.infrastructure.features.Employees.EmployeeVisualisationFlow
{
    public partial class EmployeeVisualisationFlow : Form
    {
        private List<Employee> employees = new List<Employee>();

        public EmployeeVisualisationFlow()
        {
            InitializeComponent();
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
            // Ejemplo de datos (en la práctica los tomarías de la base de datos)
            employees = new List<Employee>
            {
                new Employee { FirstName="John", LastName="Doe", Identifier="40390876", Email="john.doe@example.com", Role="Cashier", Salary=35000, HireDate=DateTime.Parse("2023-01-15") },
                new Employee { FirstName="Jane", LastName="Smith", Identifier="40210876", Email="jane.smith@example.com", Role="Manager", Salary=50000, HireDate=DateTime.Parse("2022-11-01") }
            };

            // Vincular la lista al DataGridView
            dataGridViewEmployees.DataSource = null; // reset
            dataGridViewEmployees.DataSource = employees;

            // Opcional: ajustar ancho de columnas automáticamente
            dataGridViewEmployees.AutoResizeColumns();
        }
    }
}
