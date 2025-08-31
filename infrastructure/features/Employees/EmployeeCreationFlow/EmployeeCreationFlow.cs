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



    }
}
