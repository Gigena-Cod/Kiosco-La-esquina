namespace Kiosco_La_esquina.domain.models
{
    public class Supplier
    {
        public int ID { get; set; }             // Identificador del proveedor
        public string Name { get; set; }        // Nombre o razón social
        public string Contact_Name { get; set; } // Persona de contacto
        public string Phone { get; set; }       // Teléfono
        public string Address { get; set; }     // Dirección
    }
}
