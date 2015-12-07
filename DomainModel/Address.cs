using System.Data.Entity;

namespace FHDW.Hotel.DomainModel
{
    public class Address : DbContext
    {
        public int ID { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
    }
}
