using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository;
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
        #endregion

        /// <summary>
        /// 
        /// </summary>
        public BookingService()
        {
            BookingRepository = new BookingRepository();
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
    }
}
