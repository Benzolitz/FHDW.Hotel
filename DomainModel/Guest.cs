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
        public string Emailaddress { get; set; }
        public DateTime Birthday { get; set; }
        public string Birthplace { get; set; }
        public Address ContactAddress { get; set; }
        public Address BillingAddress { get; set; }
        public string Telephone { get; set; }
    }
}
