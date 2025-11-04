using System.Data;
using Kiosco_La_esquina.domain.models;
using Kiosco_La_esquina.domain.repository;
using System.Windows.Forms;

namespace Kiosco_La_esquina.domain.services
{
    public class SaleService
    {
        private readonly Repository _repository;

        public SaleService()
        {
            _repository = new Repository();
        }

        public List<Sale> GetSales(DateTime? from = null, DateTime? to = null, int? employeeId = null)
        {
            
            var sales = new List<Sale>();

            try
            {
                string query = @"
                    SELECT 
                        s.ID,
                        s.saleDate,
                        e.FirstName,
                        e.LastName,
                        s.totalAmount
                    FROM Sale AS s
                    INNER JOIN Employee AS e 
                        ON e.ID = s.employeeId
                    WHERE 1=1";

                // agregar condiciones dinámicamente
                if (from.HasValue)
                    query += $" AND s.saleDate >= #{from.Value:yyyy-MM-dd HH:mm:ss}#";
                if (to.HasValue)
                    query += $" AND s.saleDate <= #{to.Value:yyyy-MM-dd HH:mm:ss}#";

                if (employeeId.HasValue) query += $" AND s.employeeId = {employeeId.Value}";

                query += " ORDER BY s.saleDate DESC;";

                DataTable dt = _repository.Get(query);

                foreach (DataRow row in dt.Rows)
                {
                    DateTime.TryParse(row["saleDate"]?.ToString(), out DateTime saleDate);

                    sales.Add(new Sale
                    {
                        ID = Convert.ToInt32(row["ID"]),
                        Date = saleDate,
                        EmployeeName = $"{Safe(row, "FirstName")} {Safe(row, "LastName")}".Trim(),
                        TotalAmount = Convert.ToDecimal(row["totalAmount"])
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener ventas:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return sales;
        }

        private static string Safe(DataRow r, string col) =>
            r.Table.Columns.Contains(col) && r[col] != DBNull.Value ? r[col]!.ToString()! : "";
    }
}
