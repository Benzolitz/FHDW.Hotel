using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FHDW.Hotel.DomainModel
{
    /// <summary>
    /// Guestmodel
    /// </summary>
    [Table("Guest")]
    public class Guest
    {
        /// <summary>
        /// ID of the Guest
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Fiestname of the Guest
        /// </summary>
        [Required]
        public string Firstname { get; set; }

        /// <summary>
        /// Lastname of the Guest
        /// </summary>
        [Required]
        public string Lastname { get; set; }

        /// <summary>
        /// Emailaddress of the Guest
        /// </summary>
        public string Emailaddress { get; set; }

        /// <summary>
        /// Password of the Guest
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Birthday of the Guest
        /// </summary>
        [Required]
        public DateTime Birthday { get; set; }

        /// <summary>
        /// Birtplace of the Guest
        /// </summary>
        [Required]
        public string Birthplace { get; set; }

        /// <summary>
        /// Telephonenumber of the Guest
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// Contactaddress of the Guest
        /// </summary>
        [Required]
        public Address ContactAddress { get; set; }

        /// <summary>
        /// Billingaddress of the Guest
        /// </summary>
        public Address BillingAddress { get; set; }
    }
}
