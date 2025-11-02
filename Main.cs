using Kiosco_La_esquina.domain.models;
using Kiosco_La_esquina.infrastructure.features;
using Kiosco_La_esquina.infrastructure.features.Employees;
using Kiosco_La_esquina.infrastructure.features.Employees.EmployeeDeletionFlow;
using Kiosco_La_esquina.infrastructure.features.Employees.EmployeeVisualisationFlow;
using Kiosco_La_esquina.infrastructure.features.Suppliers.SupplierCreationFlow;
using Kiosco_La_esquina.infrastructure.features.Suppliers.SupplierDeleteFlow;
using Kiosco_La_esquina.infrastructure.features.Suppliers.SupplierVisualizationFlow;

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

        private void listadoDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instanciar el formulario de visualización de proveedores
            SupplierVisualizationFlow supplierForm =
                new SupplierVisualizationFlow();

            // Mostrar el formulario
            supplierForm.Show();
        }

        private void agregarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instanciar el formulario de creación de proveedores
            SupplierCreationFlow supplierForm = new SupplierCreationFlow();

            // Mostrar el formulario
            supplierForm.Show();
        }

        private void eliminarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instanciar el formulario de eliminación de proveedores
            SupplierDeleteFlow deleteForm = new SupplierDeleteFlow();

            // Mostrar el formulario
            deleteForm.Show();
        }

    }
}

