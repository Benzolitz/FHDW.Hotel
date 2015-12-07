using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FHDW.Hotel.DomainModel
{
    /// <summary>
    /// 
    /// </summary>
    [Table("Address")]
    public class Address
    {
        public int ID { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string PostalCode { get; set; }

        [Required]
        public string City { get; set; }
    }
}