using System.Collections.Generic;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;

namespace FHDW.Hotel.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public class BookingRepository : IBookingRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ICollection<Booking> GetCollection()
        {
            return new List<Booking>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_guestId"></param>
        /// <returns></returns>
        public ICollection<Booking> GetByGuestId(int p_guestId)
        {
            return new List<Booking>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public Booking GetById(int p_id)
        {
            return new Booking();
        }
    }
}
