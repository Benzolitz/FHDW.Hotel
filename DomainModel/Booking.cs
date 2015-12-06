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

        public Guest Guest { get; set; }

        public Hotel Hotel { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}
