using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository.Database;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

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
            using (var context = new FhdwHotelContext())
            {
                var hotel = context.Hotel.SingleOrDefault(h => h.ID == p_booking.Hotel.ID);
                p_booking.Hotel = hotel;

                context.Booking.Add(p_booking);
                context.SaveChanges();
            };

            return p_booking;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_booking"></param>
        /// <returns></returns>
        public Booking Update(Booking p_booking)
        {
            using (var context = new FhdwHotelContext())
            {
                var hotel = context.Hotel.SingleOrDefault(h => h.ID == p_booking.Hotel.ID);
                p_booking.Hotel = hotel;

                context.Booking.Add(p_booking);
                context.SaveChanges();
            };

            return p_booking;
        }
    }
}
