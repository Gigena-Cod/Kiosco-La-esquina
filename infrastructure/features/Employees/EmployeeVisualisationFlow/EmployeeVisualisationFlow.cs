using Kiosco_La_esquina.domain.models;
using Kiosco_La_esquina.domain.repository;
using Kiosco_La_esquina.domain.services;
using System.Data;

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


    }
}
