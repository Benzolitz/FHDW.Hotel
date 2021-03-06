﻿using System;
using System.Collections.Generic;
using System.Linq;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository.Database;

namespace FHDW.Hotel.Repository.Repositories
{
    /// <summary>
    /// Repository for the testdata. 
    /// </summary>
    /// <author>Lucas Engel</author>
    public class DatabaseRepository : IDatabaseRepository
    {
        /// <summary>
        /// Insert a wide variety on testdata into the database.
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
        /// Add Testdata to the Database.
        /// </summary>
        /// <param name="p_addresses">A Collection with Addressobjects.</param>
        /// <param name="p_admins">A Collection with Adminobjects</param>
        /// <param name="p_bookings">A Collection with Bookingobjects</param>
        /// <param name="p_guests">A Collection with Guestobjects</param>
        /// <param name="p_hotels">A Collection with Hotelobjects</param>
        /// <param name="p_rooms">A Collection with Roomobjects</param>
        /// <param name="p_roomTypes">A Collection of RoomTypes</param>
        /// <param name="p_roomCategories">A Collection of Roomcategories.</param>
        public void InsertTestData(ICollection<Address> p_addresses, ICollection<Admin> p_admins, ICollection<Booking> p_bookings, ICollection<Guest> p_guests, ICollection<DomainModel.Hotel> p_hotels, ICollection<Room> p_rooms, ICollection<RoomType> p_roomTypes, ICollection<RoomCategory> p_roomCategories)
        {
            using (var context = new FhdwHotelContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        if (p_roomTypes != null && !context.RoomType.Any())
                        {
                            context.RoomType.AddRange(p_roomTypes);
                            context.SaveChanges();
                        }

                        if (p_roomCategories != null && !context.RoomCategory.Any())
                        {
                            context.RoomCategory.AddRange(p_roomCategories);
                            context.SaveChanges();
                        }

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
