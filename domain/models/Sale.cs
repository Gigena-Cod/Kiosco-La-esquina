namespace Kiosco_La_esquina.domain.models
{
    public class Sale
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
    }

}
