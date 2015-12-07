using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;

namespace FHDW.Hotel.Repository.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class BookingRepository : IBookingRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_booking"></param>
        /// <returns></returns>
        public Booking Insert(Booking p_booking)
        {
            return new Booking();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_booking"></param>
        /// <returns></returns>
        public Booking Update(Booking p_booking)
        {
            return new Booking();
        }
    }
}
