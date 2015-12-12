using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FHDW.Hotel.DomainModel
{
    /// <summary>
    /// Bookingmodel
    /// </summary>
    [Table("Booking")]
    public class Booking
    {
        /// <summary>
        /// ID of the booking
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Arrivaldate of the Booking
        /// </summary>
        [Required]
        public DateTime Arrival { get; set; }

        /// <summary>
        /// Departuredate of the booking
        /// </summary>
        [Required]
        public DateTime Departure { get; set; }

        /// <summary>
        /// Guest who is booking
        /// </summary>
        [Required]
        public Guest Guest { get; set; }

        /// <summary>
        /// Hotel that is booked for
        /// </summary>
        [Required]
        public Hotel Hotel { get; set; }

        /// <summary>
        /// Rooms that will be booked
        /// </summary>
        [Required]
        public ICollection<Room> Rooms { get; set; }
    }
}
