using System.Data;
using Kiosco_La_esquina.domain.models;
using Kiosco_La_esquina.domain.repository;

namespace Kiosco_La_esquina.domain.services
{
    public class SaleDetailService
    {
        private readonly Repository _repository;

        public SaleDetailService()
        {
            _repository = new Repository();
        }

        // from / to no se usan, solo se mantiene la firma
        public List<SaleDetail> GetSaleDetails(DateTime? from = null, DateTime? to = null, int? productId = null)
        {
            var list = new List<SaleDetail>();

            string q = @"
            SELECT *
            FROM SaleDetails AS d
            WHERE 1=1";


            if (productId.HasValue) q += $" AND d.productId = {productId.Value}";

            var dt = _repository.Get(q);

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new SaleDetail
                {
                    Id = Convert.ToInt32(row["ID"]),
                    SaleId = Convert.ToInt32(row["saleId"]),
                    ProductId = Convert.ToInt32(row["productId"]),
                    Quantity = Convert.ToInt32(row["quantity"]),
                    UnitPrice = Convert.ToDecimal(row["unitPrice"])
                });
            }

            return list;
        }
    }
}
