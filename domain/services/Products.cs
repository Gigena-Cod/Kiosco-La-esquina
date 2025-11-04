using System.Data;
using Kiosco_La_esquina.domain.models;
using Kiosco_La_esquina.domain.repository;

namespace Kiosco_La_esquina.domain.services
{
    public class ProductService
    {
        private readonly Repository _repository;

        public ProductService()
        {
            _repository = new Repository();
        }

        /// <summary>
        /// Obtiene la lista completa de productos desde la base de datos.
        /// </summary>
        /// <returns>Lista de <see cref="Product"/>.</returns>
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            try
            {
                string query = "SELECT * FROM Product";
                DataTable response = _repository.Get(query);

                foreach (DataRow row in response.Rows)
                {
                    products.Add(new Product
                    {
                        ID = Convert.ToInt32(row["ID"]),
                        Name = row["Name"].ToString(),
                        Category = row["Category"].ToString(),
                        SupplierID = Convert.ToInt32(row["SupplierID"]),
                        Price = Convert.ToDecimal(row["Price"]),
                        Stock = Convert.ToInt32(row["Stock"]),
                        Description = row["Description"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al obtener los productos:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            return products;
        }

        /// <summary>
        /// Agrega un nuevo producto a la base de datos.
        /// </summary>
        public bool CreateProduct(Product product)
        {
            try
            {
                string query = $@"
                INSERT INTO Product (Name, Category, SupplierID, Price, Stock, Description)
                VALUES (
                    '{product.Name.Replace("'", "''")}',
                    '{product.Category.Replace("'", "''")}',
                    {product.SupplierID},
                    {product.Price.ToString(System.Globalization.CultureInfo.InvariantCulture)},
                    {product.Stock},
                    '{product.Description.Replace("'", "''")}'
                )";

                int rowsAffected = _repository.Execute(query);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al agregar producto:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
        }

        /// <summary>
        /// Actualiza los datos de un producto existente.
        /// </summary>
        public bool UpdateProduct(Product product)
        {
            try
            {
                string query = $@"
                UPDATE Product SET
                    Name = '{product.Name.Replace("'", "''")}',
                    Category = '{product.Category.Replace("'", "''")}',
                    SupplierID = {product.SupplierID},
                    Price = {product.Price.ToString(System.Globalization.CultureInfo.InvariantCulture)},
                    Stock = {product.Stock}
                WHERE ID = {product.ID}";

                int rowsAffected = _repository.Execute(query);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al actualizar producto:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
        }

        /// <summary>
        /// Elimina un producto según su ID.
        /// </summary>
        public bool DeleteProduct(int id)
        {
            try
            {
                string query = $"DELETE FROM Product WHERE ID = {id}";
                int rowsAffected = _repository.Execute(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show(
                        "Producto eliminado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    return true;
                }
                else
                {
                    MessageBox.Show(
                        "No se encontró un producto con ese ID.",
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
                    $"Error al eliminar producto:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
        }
    }
}
