using System;
using System.Collections.Generic;

namespace FHDW.Hotel.DomainModel
{
    /// <summary>
    /// 
    /// </summary>
    public class Booking
    {
        public int ID { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime Departure { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}
