using System;

namespace FHDW.Hotel.DomainModel
{
    /// <summary>
    /// 
    /// </summary>
    public class CurrentBooking
    {
        public int ID { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime Departure { get; set; }
        public Guest Guest { get; set; }
        public Hotel Hotel { get; set; }

        public int singleRoomCnt { get; set; }
        public int doubleRoomCnt { get; set; }
        public int familyRoomCnt { get; set; }
    }
}
