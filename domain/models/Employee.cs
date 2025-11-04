namespace Kiosco_La_esquina.domain.models
{
    public class Employee
    {
        public int ID { get; set; }

        public string FirstName { get; set; }            
        public string LastName { get; set; }     
        public string Identifier { get; set; }  
        public string Email { get; set; }        
        public string Role { get; set; }         
        public decimal Salary { get; set; }      
        public DateTime HireDate { get; set; }
         
        public string FullName => $"{FirstName} {LastName}";
    }
}
 