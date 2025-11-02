using System.Data;
using Kiosco_La_esquina.domain.models;
using Kiosco_La_esquina.domain.repository;

namespace Kiosco_La_esquina.domain.services
{
    public class SupplierService
    {
        private readonly Repository _repository;

        public SupplierService()
        {
            _repository = new Repository();
        }

        /// <summary>
        /// Obtiene la lista completa de proveedores desde la base de datos.
        /// </summary>
        /// <returns>Lista de <see cref="Supplier"/>.</returns>
        public List<Supplier> GetAllSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();

            try
            {
                string query = "SELECT * FROM Supplier";
                DataTable response = _repository.Get(query);

                foreach (DataRow row in response.Rows)
                {
                    suppliers.Add(new Supplier
                    {
                        ID = Convert.ToInt32(row["ID"]),
                        Name = row["Name"].ToString(),
                        Contact_Name = row["Contact_Name"].ToString(),
                        Phone = row["Phone"].ToString(),
                        Address = row["Address"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al obtener los proveedores:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            return suppliers;
        }

        /// <summary>
        /// Agrega un nuevo proveedor a la base de datos.
        /// </summary>
        public bool CreateSupplier(Supplier supplier)
        {
            try
            {
                string query = $@"
                INSERT INTO Supplier (Name, Contact_Name, Phone, Address)
                VALUES (
                    '{supplier.Name.Replace("'", "''")}',
                    '{supplier.Contact_Name.Replace("'", "''")}',
                    '{supplier.Phone.Replace("'", "''")}',
                    '{supplier.Address.Replace("'", "''")}'
                )";

                int rowsAffected = _repository.Execute(query);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al agregar proveedor:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
        }

        /// <summary>
        /// Actualiza los datos de un proveedor existente.
        /// </summary>
        public bool UpdateSupplier(Supplier supplier)
        {
            try
            {
                string query = $@"
                UPDATE Supplier SET
                    Name = '{supplier.Name.Replace("'", "''")}',
                    ContactName = '{supplier.Contact_Name.Replace("'", "''")}',
                    Phone = '{supplier.Phone.Replace("'", "''")}',
                    Address = '{supplier.Address.Replace("'", "''")}'
                WHERE ID = {supplier.ID}";

                int rowsAffected = _repository.Execute(query);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al actualizar proveedor:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
        }

        /// <summary>
        /// Elimina un proveedor según su ID.
        /// </summary>
        public bool DeleteSupplier(int id)
        {
            try
            {
                string query = $"DELETE FROM Supplier WHERE ID = {id}";
                int rowsAffected = _repository.Execute(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show(
                        "Proveedor eliminado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    return true;
                }
                else
                {
                    MessageBox.Show(
                        "No se encontró un proveedor con ese ID.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al eliminar proveedor:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
        }
    }
}
