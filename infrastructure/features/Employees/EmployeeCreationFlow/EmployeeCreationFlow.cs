using Kiosco_La_esquina.domain.models;
using Kiosco_La_esquina.domain.services;

namespace Kiosco_La_esquina.infrastructure.features
{
    public partial class EmployeeCreationFlow : Form
    {
        public EmployeeCreationFlow()
        {
            InitializeComponent();
            SetPlaceholders();
            LoadRolesComboBox(comboBoxRole, "Cajero/a");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeCreationFlow_Load(object sender, EventArgs e)
        {

        }

        private void SetPlaceholders()
        {
            AddPlaceholder(textBoxName, "Ingrese el nombre");
            AddPlaceholder(textBoxLastName, "Ingrese el apellido");
            AddPlaceholder(textBoxIdentifier, "Ingrese el DNI");
            AddPlaceholder(textBoxEmail, "Ingrese el email");
            AddPlaceholder(textBoxSalary, "Ingrese el salario");
        }

        private void AddPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.Enter += (s, e) =>
            {
                if (textBox.ForeColor == Color.Gray)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        private void LoadRolesComboBox(ComboBox combo, string defaultValue = null)
        {
            combo.DropDownStyle = ComboBoxStyle.DropDownList;

            // Clear previous items
            combo.Items.Clear();

            // Add job roles
            combo.Items.Add("Cajero/a");
            combo.Items.Add("Atención al cliente");
            combo.Items.Add("Ambos");

            // Select default value if provided
            if (!string.IsNullOrEmpty(defaultValue) && combo.Items.Contains(defaultValue))
            {
                combo.SelectedItem = defaultValue;
            }
            else
            {
                combo.SelectedIndex = 0; // Select first item by default
            }
        }

        private void ClearFields()
        {
            // Restaurar placeholders
            textBoxName.Text = "Ingrese el nombre";
            textBoxName.ForeColor = Color.Gray;

            textBoxLastName.Text = "Ingrese el apellido";
            textBoxLastName.ForeColor = Color.Gray;

            textBoxIdentifier.Text = "Ingrese el DNI";
            textBoxIdentifier.ForeColor = Color.Gray;

            textBoxEmail.Text = "Ingrese el email";
            textBoxEmail.ForeColor = Color.Gray;

            textBoxSalary.Text = "Ingrese el salario";
            textBoxSalary.ForeColor = Color.Gray;

            // Resetear ComboBox al primer elemento
            if (comboBoxRole.Items.Count > 0)
                comboBoxRole.SelectedIndex = 0;
        }


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            // Validar campos
            if ( string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxLastName.Text) ||
                string.IsNullOrWhiteSpace(textBoxIdentifier.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxSalary.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textBoxSalary.Text, out decimal salary))
            {
                MessageBox.Show("Ingrese un salario válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear objeto Employee
            Employee newEmployee = new Employee
            {
                FirstName = textBoxName.Text,
                LastName = textBoxLastName.Text,
                Identifier = textBoxIdentifier.Text,
                Email = textBoxEmail.Text,
                Role = comboBoxRole.SelectedItem.ToString(),
                Salary = salary,
                HireDate = DateTime.Today
            };

            // Llamar al servicio
            EmployeeService service = new EmployeeService();
            bool response = service.AddEmployee(newEmployee);

            if (response)
            {
                MessageBox.Show("Empleado creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {
                MessageBox.Show("No se pudo crear el empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
