using System;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository.Database;
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
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        p_booking.Hotel = context.Hotel.SingleOrDefault(h => h.ID == p_booking.Hotel.ID);

                        context.Booking.Add(p_booking);
                        context.SaveChanges();

                        transaction.Commit();
                        return p_booking;
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine(ex.Message);
                        transaction.Rollback();
                        return null;
                    }
                }
            }
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

                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        p_booking.Hotel = context.Hotel.SingleOrDefault(h => h.ID == p_booking.Hotel.ID);

                        context.Booking.Add(p_booking);
                        context.SaveChanges();

                        transaction.Commit();
                        return p_booking;
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine(ex.Message);
                        transaction.Rollback();
                        return null;
                    }
                }
            }
        }
    }
}
