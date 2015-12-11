using System;
using System.Collections.Generic;
using System.Linq;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository.Database;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace FHDW.Hotel.Repository.Repositories
{
    /// <summary>
    /// Repository for all Room-related queries. 
    /// </summary>
    /// <author>Viktoria Pierenkemper, Lucas Engel</author>
    public class RoomRepository : IRoomRepository
    {
        /// <summary>
        /// Get a specific Room by ID.
        /// </summary>
        /// <param name="p_id">ID of the Room.</param>
        /// <returns>The requested Hotel. If no Hotel exists, return NULL.</returns>
        public Room GetById(int p_id)
        {
            using (var context = new FhdwHotelContext())
            {
                return context.Room.FirstOrDefault(r => r.ID == p_id);
            }
        }

        /// <summary>
        /// Get a Collection of all Rooms from one Hotel
        /// </summary>
        /// <param name="p_hotel">Hotelobject with an ID set</param>
        /// <returns>Collection of Rooms.</returns>
        public ICollection<Room> GetCollectionByHotel(DomainModel.Hotel p_hotel)
        {
            using (var context = new FhdwHotelContext())
            {
                return context.Room.Where(r => r.Hotel.ID == p_hotel.ID).ToList();
            }
        }

        /// <summary>
        /// Get a List of all Rooms, wich are not already booked in a specific timeframe.
        /// </summary>
        /// <param name="p_hotelId"></param>
        /// <param name="p_arrival">The Arrivaldate of the Guest.</param>
        /// <param name="p_departure">The Departuredate of the Guest.</param>
        /// <returns>List with all Rooms. If no Room exists, return an empty List.</returns>
        public ICollection<Room> GetAvailableRooms(int p_hotelId, DateTime p_arrival, DateTime p_departure)
        {
            using (var context = new FhdwHotelContext())
            {
                return context.Room.Include(b => b.Bookings)
                    .Where(r => r.Hotel.ID == p_hotelId)
                    .Where(r => !r.Bookings.Any())
                    .Where(r => r.Bookings.FirstOrDefault(bo => bo.Arrival > p_arrival) != null)
                    .Where(r => r.Bookings.FirstOrDefault(bo => bo.Departure < p_departure) != null)
                    .ToList();
            }
        }

        /// <summary>
        /// Insert a new Room into the databse.
        /// </summary>
        /// <param name="p_room">The new Room.</param>
        /// <returns>The Newly created Room-Object. NULL, or Exception if an error occurs.</returns>
        public Room Insert(Room p_room)
        {
            using (var context = new FhdwHotelContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var hotel = context.Hotel.SingleOrDefault(h => h.ID == p_room.Hotel.ID);
                        p_room.Hotel = hotel;

                        context.Room.Add(p_room);
                        context.SaveChanges();

                        transaction.Commit();
                        return p_room;
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
        /// Update an existing Room in the Database.
        /// </summary>
        /// <param name="p_room">Room to Update.</param>
        /// <returns>The updated Room-Object. NULL, or Exception if an error occurs.</returns>
        public Room Update(Room p_room)
        {
            using (var context = new FhdwHotelContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var hotel = context.Hotel.SingleOrDefault(h => h.ID == p_room.Hotel.ID);
                        p_room.Hotel = hotel;

                        context.Room.AddOrUpdate(p_room);
                        context.SaveChanges();
                        transaction.Commit();

                        return p_room;
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine(ex.Message);
                        transaction.Rollback();
                        return null;
                    }
                }
            };
        }

        /// <summary>
        /// Delete a room from the database.
        /// </summary>
        /// <param name="p_room">Roomobject with the ID set.</param>
        /// <returns>The deleted Room-Object. NULL, or Exception if an error occurs.</returns>
        public Room Delete(Room p_room)
        {
            using (var context = new FhdwHotelContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var roomToDelete = context.Room.SingleOrDefault(r => r.ID == p_room.ID);

                        context.Room.Remove(roomToDelete);
                        context.SaveChanges();
                        transaction.Commit();

                        return roomToDelete;
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
