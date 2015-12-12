using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FHDW.Hotel.DomainModel
{
    /// <summary>
    /// Hotelmodel
    /// </summary>
    [Table("Hotel")]
    public class Hotel
    {
        /// <summary>
        /// ID of the Hotel
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Name of the Hotel
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Address of the Hotel
        /// </summary>
        [Required]
        public Address Address { get; set; }
        
        /// <summary>
        /// Rooms that the Hotel posseses
        /// </summary>
        public ICollection<Room> Rooms { get; set; }
    }
}
