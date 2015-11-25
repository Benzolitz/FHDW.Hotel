using System.Collections.Generic;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;

namespace FHDW.Hotel.Repository
{
    /// <summary>
    /// Every Request returning a Booking-Object will be handled in this Repository.
    /// </summary>
    public class BookingRepository : BaseRepository, IBookingRepository
    {
        /// <summary>
        /// Get a List of all Bookings in the database.
        /// </summary>
        /// <returns>List with all Bookings. If no Bookings exists, return an empty List.</returns>
        public ICollection<Booking> GetCollection()
        {
            return new List<Booking>();
        }

        /// <summary>
        /// Get only the bookings, made by a specific Guest.
        /// </summary>
        /// <param name="p_guestId">ID of the Guest.</param>
        /// <returns>All Bookings made by a specific Guest. If no Bookings exists, return an empty List.</returns>
        public ICollection<Booking> GetByGuestId(int p_guestId)
        {
            return new List<Booking>();
        }

        /// <summary>
        /// Get a specific Booking.
        /// </summary>
        /// <param name="p_id">ID of the booking</param>
        /// <returns>The requested Booking. If no Booking exists, return NULL.</returns>
        public Booking GetById(int p_id)
        {
            return new Booking();
        }
    }
}
