using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Kiosco_La_esquina.domain.models;
using Kiosco_La_esquina.domain.services;

namespace Kiosco_La_esquina.infrastructure.features.Suppliers.SupplierCreationFlow
{
    public partial class SupplierCreationFlow : Form
    {
        private SupplierService _supplierService;

        public SupplierCreationFlow()
        {
            InitializeComponent();
            _supplierService = new SupplierService();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                MessageBox.Show("El nombre del proveedor es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                firstNameTextBox.Focus();
                return;            
            }            

            // Crear objeto Supplier
            Supplier newSupplier = new Supplier
            {
                Name = firstNameTextBox.Text.Trim(),
                Contact_Name = contactNameTextBox.Text.Trim(),
                Address = addressTextBox.Text.Trim(),
                Phone = phoneTextBox.Text.Trim()
            };

            // Guardar en la base de datos a través del servicio
            bool success = _supplierService.CreateSupplier(newSupplier);

            if (success)
            {
                MessageBox.Show("Proveedor creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Cierra el formulario después de crear
            }
            else
            {
                MessageBox.Show("Ocurrió un error al crear el proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
