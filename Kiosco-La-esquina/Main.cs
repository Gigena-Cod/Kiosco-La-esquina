using Kiosco_La_esquina.infrastructure.features;

namespace Kiosco_La_esquina
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void agregarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            EmployeeCreationFlow employeeForm = new EmployeeCreationFlow();

          
            employeeForm.Show();
           
        }
    }
}

