using System.Collections.Generic;
using FHDW.Hotel.DomainModel;

namespace FHDW.Hotel.IRepository
{
    /// <summary>
    /// Interface for all Testdata related stuff.
    /// </summary>
    /// <author>Lucas Engel</author>
    public interface IDatabaseRepository
    {
        /// <summary>
        /// Insert a wide variety on testdata into the database.
        /// </summary>
        void CreateDatabase();

        /// <summary>
        /// Add Testdata to the Database.
        /// </summary>
        /// <param name="p_addresses">A Collection with Addressobjects.</param>
        /// <param name="p_admins">A Collection with Adminobjects</param>
        /// <param name="p_bookings">A Collection with Bookingobjects</param>
        /// <param name="p_guests">A Collection with Guestobjects</param>
        /// <param name="p_hotels">A Collection with Hotelobjects</param>
        /// <param name="p_rooms">A Collection with Roomobjects</param>
        void InsertTestData(ICollection<Address> p_addresses, ICollection<Admin> p_admins, ICollection<Booking> p_bookings, ICollection<Guest> p_guests, ICollection<DomainModel.Hotel> p_hotels, ICollection<Room> p_rooms);
    }
}
