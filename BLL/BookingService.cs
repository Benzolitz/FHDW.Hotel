using System.Collections.Generic;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository.Repositories;

namespace FHDW.Hotel.BLL
{
    /// <summary>
    /// 
    /// </summary>
    public class BookingService
    {
        #region Dependencies
        private IBookingRepository BookingRepository;
        private IRoomRepository RoomRepository;
        #endregion

        /// <summary>
        /// 
        /// </summary>
        public BookingService()
        {
            BookingRepository = new BookingRepository();
            RoomRepository = new RoomRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_booking"></param>
        /// <returns></returns>
        public Booking Save(Booking p_booking)
        {
            return p_booking.ID == 0 ? BookingRepository.Insert(p_booking) : BookingRepository.Update(p_booking);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_booking"></param>
        /// <param name="p_singleRoomCount"></param>
        /// <param name="p_doubleRoomCount"></param>
        /// <param name="p_familyRoomCount"></param>
        /// <returns></returns>
        public Booking Save(CurrentBooking p_booking)
        {
            var availableRooms = RoomRepository.GetAvailableRooms(p_booking.Hotel.ID, p_booking.Arrival, p_booking.Departure);
            var single = 0;
            var doubleR = 0;
            var family = 0;

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
                switch (availableRoom.Type)
                {
                    case Enums.RoomType.Single:
                        if (single < p_booking.singleRoomCnt)
                        {
                            single++;
                            booking.Rooms.Add(availableRoom);
                        }

                        break;
                    case Enums.RoomType.Double:
                        if (doubleR < p_booking.doubleRoomCnt)
                        {
                            doubleR++;
                            booking.Rooms.Add(availableRoom);
                        }

                        break;
                    case Enums.RoomType.Family:
                        if (family < p_booking.familyRoomCnt)
                        {
                            family++;
                            booking.Rooms.Add(availableRoom);
                        }
                        break;
                }
            }
            return BookingRepository.Insert(booking);
        }
    }
}
