using Kiosco_La_esquina.infrastructure.features;
using Kiosco_La_esquina.infrastructure.features.Employees;
using Kiosco_La_esquina.infrastructure.features.Employees.EmployeeDeletionFlow;
using Kiosco_La_esquina.infrastructure.features.Employees.EmployeeVisualisationFlow;

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

        private void listadoDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeVisualisationFlow employeeForm = new EmployeeVisualisationFlow();

            employeeForm.Show();
        }

        private void modificarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeUpdateFlow employeeForm = new EmployeeUpdateFlow();

            employeeForm.Show();
        }
    }
}

