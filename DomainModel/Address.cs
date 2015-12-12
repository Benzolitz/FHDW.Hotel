using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FHDW.Hotel.DomainModel
{
    /// <summary>
    /// Addressmodel
    /// </summary>
    [Table("Address")]
    public class Address
    {
        /// <summary>
        /// ID of the address
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Street of the address
        /// </summary>
        [Required]
        public string Street { get; set; }

        /// <summary>
        /// Postalcode of the address
        /// </summary>
        [Required]
        public string PostalCode { get; set; }

        /// <summary>
        /// City of the address
        /// </summary>
        [Required]
        public string City { get; set; }
    }
}