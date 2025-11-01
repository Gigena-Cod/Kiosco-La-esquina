using Kiosco_La_esquina.domain.models;
using Kiosco_La_esquina.domain.services;

namespace Kiosco_La_esquina.infrastructure.features.Employees
{
    public partial class EmployeeUpdateFlow : Form
    {
        private Employee currentEmployee;
        private EmployeeService service;
        private bool changesMade = false;

       

        public EmployeeUpdateFlow()
        {
            InitializeComponent();
            service = new EmployeeService();

            LoadEmployeesComboBox();

            buttonCreate.Enabled = false;

            // Eventos para detectar cambios
            firstNameTextBox.TextChanged += OnFieldChanged;
            lastNameTextBox.TextChanged += OnFieldChanged;
            emailTextBox.TextChanged += OnFieldChanged;
            roleComboBox.TextChanged += OnFieldChanged;
            salaryTextBox.TextChanged += OnFieldChanged;
            hireDatePicker.ValueChanged += OnFieldChanged;

            comboBoxEmpleado.SelectedIndexChanged += comboBoxEmpleado_SelectedIndexChanged;
        }


        private void OnFieldChanged(object sender, EventArgs e)
        {
            changesMade = true;
            buttonCreate.Enabled = true; // habilitar botón si hay cambios
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (!changesMade)
            {
                MessageBox.Show("No se han realizado cambios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Actualizar datos en el objeto
            currentEmployee.FirstName = firstNameTextBox.Text.Trim();
            currentEmployee.LastName = lastNameTextBox.Text.Trim();
            currentEmployee.Email = emailTextBox.Text.Trim();
            currentEmployee.Role = roleComboBox.Text;
            if (decimal.TryParse(salaryTextBox.Text, out decimal salary))
                currentEmployee.Salary = salary;
            currentEmployee.HireDate = hireDatePicker.Value;

            // Guardar en la base de datos
            bool success = service.UpdateEmployee(currentEmployee);

            if (success)
            {
                MessageBox.Show("Empleado actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonCreate.Enabled = false;
                changesMade = false;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool isLoading = false;

        private void LoadEmployeesComboBox()
        {
            isLoading = true; // desactivar evento temporalmente

            var employees = service.GetAllEmployees();
            comboBoxEmpleado.DataSource = employees;
            comboBoxEmpleado.DisplayMember = "FullName";
            comboBoxEmpleado.ValueMember = "Identifier";
            comboBoxEmpleado.SelectedIndex = -1;

            isLoading = false; // volver a activar
        }

        private void comboBoxEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading) return; // ignorar si todavía se está cargando
            if (comboBoxEmpleado.SelectedIndex == -1) return;

            currentEmployee = comboBoxEmpleado.SelectedItem as Employee;

            if (currentEmployee != null)
            {
                firstNameTextBox.Text = currentEmployee.FirstName;
                lastNameTextBox.Text = currentEmployee.LastName;
                identifierTextBox.Text = currentEmployee.Identifier;
                emailTextBox.Text = currentEmployee.Email;
                roleComboBox.Text = currentEmployee.Role;
                salaryTextBox.Text = currentEmployee.Salary.ToString();
                hireDatePicker.Value = currentEmployee.HireDate;

                changesMade = false;
                buttonCreate.Enabled = false;
            }
        }


    }
}
