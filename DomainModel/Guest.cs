using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FHDW.Hotel.DomainModel
{
    /// <summary>
    /// 
    /// </summary>
    [Table("Guest")]
    public class Guest
    {
        public int ID { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        public string Emailaddress { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [Required]
        public string Birthplace { get; set; }

        public string Telephone { get; set; }

        [Required]
        public Address ContactAddress { get; set; }

        public Address BillingAddress { get; set; }
    }
}
