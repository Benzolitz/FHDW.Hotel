using System.Collections.Generic;

namespace FHDW.Hotel.DomainModel
{
    /// <summary>
    /// 
    /// </summary>
    public class Hotel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Postalcode { get; set; }
        public string City { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }
}
