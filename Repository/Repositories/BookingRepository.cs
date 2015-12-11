using System;
using System.Collections.Generic;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository.Database;
using System.Linq;

namespace FHDW.Hotel.Repository.Repositories
{
    /// <summary>
    /// Repository for all Booking-related queries. 
    /// </summary>
    /// <author>Viktoria Pierenkemper, Lucas Engel</author>
    public class BookingRepository : IBookingRepository
    {
        /// <summary>
        /// Insert a new booking into the database.
        /// </summary>
        /// <param name="p_booking">Bookingobject without an ID.</param>
        /// <returns>Filled Bookingobject.</returns>
        public Booking Insert(Booking p_booking)
        {
            using (var context = new FhdwHotelContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        p_booking.Hotel = context.Hotel.SingleOrDefault(h => h.ID == p_booking.Hotel.ID);
                        if (p_booking.Guest != null && p_booking.Guest.ID > 0)
                        {
                            p_booking.Guest = context.Guest.SingleOrDefault(g => g.ID == p_booking.Guest.ID);
                            if (p_booking.Guest.ContactAddress.ID > 0) p_booking.Guest.ContactAddress = context.Address.SingleOrDefault(a => a.ID == p_booking.Guest.ContactAddress.ID);
                            if (p_booking.Guest.BillingAddress.ID > 0) p_booking.Guest.BillingAddress = context.Address.SingleOrDefault(a => a.ID == p_booking.Guest.BillingAddress.ID);
                        }

                        var rooms = p_booking.Rooms;
                        p_booking.Rooms = new List<Room>();
                        foreach (var room in rooms)
                        {
                            p_booking.Rooms.Add(context.Room.FirstOrDefault(r => r.ID == room.ID));
                        }


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
        /// Update an existing Booking entry.
        /// </summary>
        /// <param name="p_booking">Bookingobject with an ID.</param>
        /// <returns>Updated Bookingobject.</returns>
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
