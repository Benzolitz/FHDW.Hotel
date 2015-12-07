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
    public class DatabaseRepository : BaseRepository, IDatabaseRepository
    {
        /// <summary>
        /// 
        /// </summary>
        public void CreateDatabase()
        {
            using (var connection = base.currentConnection)
            {
                // Create database if not exists
                using (var contextDb = new FhdwHotelContext(connection, false))
                {
                    contextDb.Database.CreateIfNotExists();
                }

                connection.Open();
                var transaction = connection.BeginTransaction();

                try
                {
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void InsertTestData(ICollection<Address> p_addresses, ICollection<Admin> p_admins, ICollection<Booking> p_bookings, ICollection<Guest> p_guests, ICollection<DomainModel.Hotel> p_hotels, ICollection<Room> p_rooms)
        {
            using (var connection = base.currentConnection)
            {
                connection.Open();
                var transaction = connection.BeginTransaction();

                try
                {
                    using (var context = new FhdwHotelContext(connection, false))
                    {
                        context.Database.Log = Console.WriteLine;
                        context.Database.UseTransaction(transaction);
                        
                        if (p_addresses != null && !context.Address.Any()) context.Address.AddRange(p_addresses);
                        if (p_admins != null && !context.Admin.Any()) context.Admin.AddRange(p_admins);
                        if (p_bookings != null && !context.Booking.Any()) context.Booking.AddRange(p_bookings);
                        if (p_guests != null && !context.Guest.Any()) context.Guest.AddRange(p_guests);
                        if (p_hotels != null && !context.Hotel.Any()) context.Hotel.AddRange(p_hotels);
                        if (p_rooms != null && !context.Room.Any()) context.Room.AddRange(p_rooms);

                        context.SaveChanges();
                    }

                    transaction.Commit();
                }
                catch(Exception ex)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
