using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FHDW.Hotel.DomainModel
{
    /// <summary>
    /// Roomodel
    /// </summary>
    [Table("Room")]
    public class Room
    {
        /// <summary>
        /// ID of the Room
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Number of the Room
        /// </summary>
        public string RoomNumber { get; set; }

        /// <summary>
        /// Personcount of the Room
        /// </summary>
        public int PersonCount { get; set; }

        /// <summary>
        /// Price of the Room
        /// </summary>
        public float Price { get; set; }

        /// <summary>
        /// Category of the Room
        /// </summary>
        public RoomCategory Category { get; set; }

        /// <summary>
        /// Type of the Room
        /// </summary>
        public RoomType Type { get; set; }

        /// <summary>
        /// Hotel that the Room is added to
        /// </summary>
        public Hotel Hotel { get; set; }

        /// <summary>
        /// All bookings of the Room
        /// </summary>
        public ICollection<Booking> Bookings { get; set; }
    }
}