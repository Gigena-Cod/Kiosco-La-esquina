using Kiosco_La_esquina.domain.models;
using Kiosco_La_esquina.domain.services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Kiosco_La_esquina.infrastructure.features.Suppliers.SupplierUpdateFlow
{
    public partial class SupplierUpdateFlow : Form
    {
        private Supplier currentSupplier;
        private SupplierService service;
        private bool changesMade = false;
        private bool isLoading = false;

        public SupplierUpdateFlow()
        {
            InitializeComponent();

            service = new SupplierService();

            LoadSuppliersComboBox();

            buttonUpdate.Enabled = false;

            // Eventos para detectar cambios en los campos
            nameTextBox.TextChanged += OnFieldChanged;
            contactNameTextBox.TextChanged += OnFieldChanged;
            phoneTextBox.TextChanged += OnFieldChanged;
            addressTextBox.TextChanged += OnFieldChanged;

            comboBoxSuppliers.SelectedIndexChanged += comboBoxSuppliers_SelectedIndexChanged;
        }

        private void OnFieldChanged(object sender, EventArgs e)
        {
            changesMade = true;
            buttonUpdate.Enabled = true;
        }

        private void LoadSuppliersComboBox()
        {
            isLoading = true;

            var suppliers = service.GetAllSuppliers();

            comboBoxSuppliers.DataSource = suppliers;
            comboBoxSuppliers.DisplayMember = "Name";
            comboBoxSuppliers.ValueMember = "ID";
            comboBoxSuppliers.SelectedIndex = -1;

            isLoading = false;
        }

        private void comboBoxSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading) return;
            if (comboBoxSuppliers.SelectedIndex == -1) return;

            currentSupplier = comboBoxSuppliers.SelectedItem as Supplier;

            if (currentSupplier != null)
            {
                nameTextBox.Text = currentSupplier.Name;
                contactNameTextBox.Text = currentSupplier.Contact_Name;
                phoneTextBox.Text = currentSupplier.Phone;
                addressTextBox.Text = currentSupplier.Address;

                changesMade = false;
                buttonUpdate.Enabled = false;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!changesMade)
            {
                MessageBox.Show("No se han realizado cambios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (currentSupplier == null)
            {
                MessageBox.Show("Seleccione un proveedor antes de actualizar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Actualizar los datos del proveedor actual
            currentSupplier.Name = nameTextBox.Text.Trim();
            currentSupplier.Contact_Name = contactNameTextBox.Text.Trim();
            currentSupplier.Phone = phoneTextBox.Text.Trim();
            currentSupplier.Address = addressTextBox.Text.Trim();

            // Guardar cambios
            bool success = service.UpdateSupplier(currentSupplier);

            if (success)
            {
                MessageBox.Show("Proveedor actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonUpdate.Enabled = false;
                changesMade = false;
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
