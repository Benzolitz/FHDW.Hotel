using System.Collections.Generic;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository.Repositories;

namespace FHDW.Hotel.BLL
{
    /// <summary>
    /// Handles all logical decisions for the Bookingobject.
    /// </summary>
    /// <author>Lucas Engel</author>
    public class BookingService
    {
        #region Dependencies
        private readonly IBookingRepository _bookingRepository;
        private readonly IRoomRepository _roomRepository;
        #endregion

        /// <summary>
        /// Initialize the Service
        /// </summary>
        public BookingService()
        {
            _bookingRepository = new BookingRepository();
            _roomRepository = new RoomRepository();
        }

        /// <summary>
        /// Save a booking. Depending on the ID, the booking will be inserted, or updated.
        /// </summary>
        /// <param name="p_booking">Bookingobject</param>
        /// <returns>Full Bookingobject, or NULL</returns>
        public Booking Save(Booking p_booking)
        {
            return p_booking.ID == 0 ? _bookingRepository.Insert(p_booking) : _bookingRepository.Update(p_booking);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_booking"></param>
        /// <returns></returns>
        public Booking Save(CurrentBooking p_booking)
        {
            var availableRooms = _roomRepository.GetAvailableRooms(p_booking.Hotel.ID, p_booking.Arrival, p_booking.Departure);

            var booking = new Booking
            {
                Hotel = p_booking.Hotel,
                Arrival = p_booking.Arrival,
                Departure = p_booking.Departure,
                Guest = p_booking.Guest,
                Rooms = new List<Room>()
            };
            
            foreach (var availableRoom in availableRooms)
            {
                booking.Rooms.Add(availableRoom);
            }

            return _bookingRepository.Insert(booking);
        }
    }
}
