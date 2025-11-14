using Kiosco_La_esquina.domain.models;
using Kiosco_La_esquina.infrastructure.features;
using Kiosco_La_esquina.infrastructure.features.Employees;
using Kiosco_La_esquina.infrastructure.features.Employees.EmployeeDeletionFlow;
using Kiosco_La_esquina.infrastructure.features.Employees.EmployeeVisualisationFlow;
using Kiosco_La_esquina.infrastructure.features.Products.ProductCreationFlow;
using Kiosco_La_esquina.infrastructure.features.Products.ProductDeleteFlow;
using Kiosco_La_esquina.infrastructure.features.Products.ProductUpdateFlow;
using Kiosco_La_esquina.infrastructure.features.Products.ProductVisualizationFlow;
using Kiosco_La_esquina.infrastructure.features.Reports.Sales; 
using Kiosco_La_esquina.infrastructure.features.Sales.SalesVisualizationFlow;
using Kiosco_La_esquina.infrastructure.features.Suppliers.SupplierCreationFlow;
using Kiosco_La_esquina.infrastructure.features.Suppliers.SupplierDeleteFlow;
using Kiosco_La_esquina.infrastructure.features.Suppliers.SupplierUpdateFlow;
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

        private void modificarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instanciar el formulario de actualizacion de proveedores
            SupplierUpdateFlow updateForm = new SupplierUpdateFlow();

            // Mostrar el formulario
            updateForm.Show();
        }

        private void listadoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductVisualizationFlow productForm = new ProductVisualizationFlow();
            productForm.Show();
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductCreationFlow productForm = new ProductCreationFlow();
            productForm.Show();
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductUpdateFlow productForm = new ProductUpdateFlow();
            productForm.Show();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductDeleteFlow productForm = new ProductDeleteFlow();
            productForm.Show();
        }

        private void listadoDeVentasDelDíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesVisualizationFlow saleForm = new SalesVisualizationFlow();
            saleForm.Show();
        }


        private void productoMásVendidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales frm = new Sales();
            frm.ShowDialog();
        }
    }
}

