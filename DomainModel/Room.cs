using System.Collections.Generic;

namespace FHDW.Hotel.DomainModel
{
    /// <summary>
    /// 
    /// </summary>
    public class Room
    {
        public int ID { get; set; }
        public Enums.RoomCategory Category { get; set; }
        public Enums.RoomType Type { get; set; }
        public int PersonCount { get; set; }
        public float Price { get; set; }

        public ICollection<Room> Rooms { get; set; }
        public int GuestID { get; set; }
    }
}
