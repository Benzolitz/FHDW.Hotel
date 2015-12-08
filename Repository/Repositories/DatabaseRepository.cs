using System;
using System.Collections.Generic;
using System.Linq;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository.Database;

namespace FHDW.Hotel.Repository.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class DatabaseRepository : IDatabaseRepository
    {
        /// <summary>
        /// 
        /// </summary>
        public void CreateDatabase()
        {
            using (var context = new FhdwHotelContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine(ex.Message);
                        transaction.Rollback();
                    }
                }
                context.Database.CreateIfNotExists();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void InsertTestData(ICollection<Address> p_addresses, ICollection<Admin> p_admins, ICollection<Booking> p_bookings, ICollection<Guest> p_guests, ICollection<DomainModel.Hotel> p_hotels, ICollection<Room> p_rooms)
        {
            using (var context = new FhdwHotelContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        if (p_admins != null && !context.Admin.Any())
                        {
                            context.Admin.AddRange(p_admins);
                            context.SaveChanges();
                        }

                        if (p_addresses != null && !context.Address.Any())
                        {
                            context.Address.AddRange(p_addresses);
                            context.SaveChanges();
                        }

                        if (p_hotels != null && !context.Hotel.Any())
                        {
                            foreach (var hotel in p_hotels)
                            {
                                hotel.Address = context.Address.SingleOrDefault(a => a.ID == hotel.Address.ID);
                                context.Hotel.Add(hotel);
                            }
                            context.SaveChanges();
                        }

                        if (p_rooms != null && !context.Room.Any())
                        {
                            foreach (var room in p_rooms)
                            {
                                room.Hotel = context.Hotel.SingleOrDefault(h => h.ID == room.Hotel.ID);
                                context.Room.Add(room);
                            }
                            context.SaveChanges();
                        }

                        if (p_guests != null && !context.Guest.Any())
                        {
                            foreach (var guest in p_guests)
                            {
                                if (guest.ContactAddress != null) guest.ContactAddress = context.Address.SingleOrDefault(a => a.ID == guest.ContactAddress.ID);
                                if (guest.BillingAddress != null) guest.BillingAddress = context.Address.SingleOrDefault(a => a.ID == guest.BillingAddress.ID);
                                context.Guest.Add(guest);
                            }
                            context.SaveChanges();
                        }

                        if (p_bookings != null && !context.Booking.Any()) context.Booking.AddRange(p_bookings);

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine(ex.Message);
                        transaction.Rollback();
                    }
                }
            }
        }
    }
}
