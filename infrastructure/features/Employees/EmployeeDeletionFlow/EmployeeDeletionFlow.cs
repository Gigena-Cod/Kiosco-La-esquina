using Kiosco_La_esquina.domain.models;
using Kiosco_La_esquina.domain.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Kiosco_La_esquina.infrastructure.features.Employees.EmployeeDeletionFlow
{
    public partial class EmployeeDeletionFlow : Form
    {
        private List<Employee> employees;
        private Employee selectedEmployee;

        public EmployeeDeletionFlow()
        {
            InitializeComponent();
            EmployeeService service = new EmployeeService();
            employees = service.GetAllEmployees();

            CargarComboBoxEmpleados();
        }

        private void CargarComboBoxEmpleados()
        {
            if (employees == null || employees.Count == 0)
            {
                comboBoxEmpleado.DataSource = null;
                MessageBox.Show("No hay empleados cargados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            comboBoxEmpleado.DataSource = null; // reset previo
            comboBoxEmpleado.DataSource = employees;
            comboBoxEmpleado.DisplayMember = "FullName"; // propiedad auxiliar (la agregamos abajo)
            comboBoxEmpleado.ValueMember = "Identifier";
        }

        private void comboBoxEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEmpleado.SelectedItem is Employee employee)
            {
                selectedEmployee = employee;

                firstNameTextBox.Text = employee.FirstName;
                lastNameTextBox.Text = employee.LastName;
                identifierTextBox.Text = employee.Identifier;
                emailTextBox.Text = employee.Email;
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (selectedEmployee == null)
            {
                MessageBox.Show("Seleccione un empleado para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"¿Está seguro que desea eliminar al empleado {selectedEmployee.FirstName} {selectedEmployee.LastName}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    EmployeeService service = new EmployeeService();
                    service.DeleteEmployee(selectedEmployee.Identifier);

                    MessageBox.Show("Empleado eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    employees.Remove(selectedEmployee);
                    selectedEmployee = null;

                    CargarComboBoxEmpleados();

                    firstNameTextBox.Clear();
                    lastNameTextBox.Clear();
                    identifierTextBox.Clear();
                    emailTextBox.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
