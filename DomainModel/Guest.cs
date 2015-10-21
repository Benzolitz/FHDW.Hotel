using System;

namespace FHDW.Hotel.DomainModel
{
    /// <summary>
    /// 
    /// </summary>
    public class Guest
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string EMail { get; set; }
        public DateTime Birthday { get; set; }
        public string BirthCity { get; set; }
        public string Address { get; set; }
        public string Postalcode { get; set; }
        public string City { get; set; }
        public string Username { get; set; }
        public string IBAN { get; set; }
        public string BIC { get; set; }
    }
}
