using Kiosco_La_esquina.domain.models;
using Kiosco_La_esquina.domain.services;

namespace Kiosco_La_esquina.infrastructure.features.Suppliers.SupplierDeleteFlow
{
    public partial class SupplierDeleteFlow : Form
    {
        private List<Supplier> suppliers;
        private Supplier selectedSupplier;

        public SupplierDeleteFlow()
        {
            InitializeComponent();

            SupplierService service = new SupplierService();
            suppliers = service.GetAllSuppliers();

            CargarComboBoxProveedores();
        }

        private void CargarComboBoxProveedores()
        {
            if (suppliers == null || suppliers.Count == 0)
            {
                comboBoxSuppliers.DataSource = null;
                MessageBox.Show("No hay proveedores cargados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            comboBoxSuppliers.DataSource = null; // reset previo
            comboBoxSuppliers.DataSource = suppliers;
            comboBoxSuppliers.DisplayMember = "Name";  // Muestra el nombre en el combo
            comboBoxSuppliers.ValueMember = "ID";      // Valor interno
        }

     

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectedSupplier == null)
            {
                MessageBox.Show("Seleccione un proveedor para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"¿Está seguro que desea eliminar al proveedor '{selectedSupplier.Name}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    SupplierService service = new SupplierService();
                    service.DeleteSupplier(selectedSupplier.ID);

                    MessageBox.Show("Proveedor eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    suppliers.Remove(selectedSupplier);
                    selectedSupplier = null;

                    CargarComboBoxProveedores();

                    nameTextBox.Clear();
                    contactNameTextBox.Clear();
                    phoneTextBox.Clear();
                    addressTextBox.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSuppliers.SelectedItem is Supplier supplier)
            {
                selectedSupplier = supplier;

                nameTextBox.Text = supplier.Name;
                contactNameTextBox.Text = supplier.Contact_Name;
                phoneTextBox.Text = supplier.Phone;
                addressTextBox.Text = supplier.Address;
            }
        }
    }
}
