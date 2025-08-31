using Kiosco_La_esquina.infrastructure.features;
using Kiosco_La_esquina.infrastructure.features.Employees.EmployeeDeletionFlow;

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

        private void eliminarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeDeletionFlow employeeForm = new EmployeeDeletionFlow();


            employeeForm.Show();
        }
    }
}

