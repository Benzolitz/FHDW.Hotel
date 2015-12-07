using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FHDW.Hotel.DomainModel
{
    /// <summary>
    /// 
    /// </summary>
    [Table("Booking")]
    public class Booking
    {
        public int ID { get; set; }

        [Required]
        public DateTime Arrival { get; set; }

        [Required]
        public DateTime Departure { get; set; }

        [Required]
        public Guest Guest { get; set; }

        [Required]
        public Hotel Hotel { get; set; }

        [Required]
        public ICollection<Room> Rooms { get; set; }
    }
}
