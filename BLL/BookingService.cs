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
        public Booking Save(Booking p_booking, int p_singleRoomCount, int p_doubleRoomCount, int p_familyRoomCount)
        {
            var availableRooms = RoomRepository.GetAvailableRooms(p_booking.Hotel.ID, p_booking.Arrival, p_booking.Departure);
            var single = 0;
            var doubleR = 0;
            var family = 0;

            foreach (var availableRoom in availableRooms)
            {
                switch (availableRoom.Type)
                {
                    case Enums.RoomType.Single:
                        if (single < p_singleRoomCount)
                        {
                            single++;
                            p_booking.Rooms.Add(availableRoom);
                        }

                        break;
                    case Enums.RoomType.Double:
                        if (doubleR < p_doubleRoomCount)
                        {
                            doubleR++;
                            p_booking.Rooms.Add(availableRoom);
                        }

                        break;
                    case Enums.RoomType.Family:
                        if (family < p_familyRoomCount)
                        {
                            family++;
                            p_booking.Rooms.Add(availableRoom);
                        }
                        break;
                }
            }
            return BookingRepository.Insert(p_booking);
        }
    }
}
