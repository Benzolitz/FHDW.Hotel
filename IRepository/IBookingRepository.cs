using FHDW.Hotel.DomainModel;

namespace FHDW.Hotel.IRepository
{
    /// <summary>
    /// Interface for all Booking-Queries.
    /// </summary>
    /// <author>Lucas Engel</author>
    public interface IBookingRepository
    {
        /// <summary>
        /// Insert a new booking into the database.
        /// </summary>
        /// <param name="p_booking">Bookingobject without an ID.</param>
        /// <returns>Filled Bookingobject.</returns>
        Booking Insert(Booking p_booking);

        /// <summary>
        /// Update an existing Booking entry.
        /// </summary>
        /// <param name="p_booking">Bookingobject with an ID.</param>
        /// <returns>Updated Bookingobject.</returns>
        Booking Update(Booking p_booking);
    }
}
