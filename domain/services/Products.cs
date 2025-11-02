using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
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
                string query = "SELECT * FROM Product"; // Nombre de la tabla
                DataTable response = _repository.Get(query);

                foreach (DataRow row in response.Rows)
                {
                    products.Add(new Product
                    {
                        ID = Convert.ToInt32(row["ID"]),
                        Name = row["Name"].ToString(),
                        Description = row["Description"].ToString(),
                        Price = Convert.ToDecimal(row["Price"]),
                        Stock = Convert.ToInt32(row["Stock"]),
                        Category = row["Category"].ToString(),
                        SupplierID = Convert.ToInt32(row["SupplierID"])
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
    }
}
