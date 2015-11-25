using System;
using System.Collections.Generic;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository;

namespace FHDW.Hotel.BLL
{
    /// <summary>
    /// 
    /// </summary>
    public class BookingService
    {
        #region Dependencies
        private IBookingRepository BookingRepository { get; set; }
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
        /// <returns></returns>
        public ICollection<Booking> GetCollection()
        {
            return BookingRepository.GetCollection();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_guestId"></param>
        /// <returns></returns>
        public ICollection<Booking> GetByGuestId(int p_guestId)
        {
            return BookingRepository.GetByGuestId(p_guestId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public Booking GetById(int p_id)
        {
            return BookingRepository.GetById(p_id);
        }
    }
}
