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

        public List<Sale> GetSales(DateTime? from = null, DateTime? to = null, int? employeeId = null, int? saleId = null)
        {
            var sales = new List<Sale>();
            string q = @"
        SELECT s.ID, s.saleDate, e.FirstName, e.LastName, s.totalAmount
        FROM Sale AS s
        INNER JOIN Employee AS e ON e.ID = s.employeeId
        WHERE 1=1";

            if (from.HasValue) q += $" AND s.saleDate >= #{from:yyyy-MM-dd HH:mm:ss}#";
            if (to.HasValue) q += $" AND s.saleDate <= #{to:yyyy-MM-dd HH:mm:ss}#";
            if (employeeId.HasValue) q += $" AND s.employeeId = {employeeId.Value}";
            if (saleId.HasValue) q += $" AND s.ID = {saleId.Value}";

            q += " ORDER BY s.saleDate DESC;";

            var dt = _repository.Get(q);
            foreach (DataRow row in dt.Rows)
            {
                DateTime.TryParse(row["saleDate"]?.ToString(), out var saleDate);
                sales.Add(new Sale
                {
                    ID = Convert.ToInt32(row["ID"]),
                    Date = saleDate,
                    EmployeeName = $"{Safe(row, "FirstName")} {Safe(row, "LastName")}".Trim(),
                    TotalAmount = Convert.ToDecimal(row["totalAmount"])
                });
            }
            return sales;
        }


        private static string Safe(DataRow r, string col) =>
            r.Table.Columns.Contains(col) && r[col] != DBNull.Value ? r[col]!.ToString()! : "";
    }
}
