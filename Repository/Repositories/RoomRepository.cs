using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository.Database;

namespace FHDW.Hotel.Repository.Repositories
{
    /// <summary>
    /// Every Request returning a Room-Object will be handled in this Repository.
    /// </summary>
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
                return context.Room.First(r => r.ID == p_id);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_hotel"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
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
                /*
                     Hole alle Rooms (context.Room) in einem Hotel die zum gewünschten Zeitraum frei sind (Where...) und wandel das Ergebniss in eine Liste (ToList()).
                */
                context.Room.Where(h => h.Hotel.ID == p_hotelId).ToList();
            }
            return null;
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
                var hotel = context.Hotel.SingleOrDefault(h => h.ID == p_room.Hotel.ID);
                p_room.Hotel = hotel;

                context.Room.Add(p_room);
                context.SaveChanges();

                return p_room;
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
                var hotel = context.Hotel.SingleOrDefault(h => h.ID == p_room.Hotel.ID);
	            p_room.Hotel = hotel;

                context.Room.Add(p_room);
                context.SaveChanges();
            };

            return p_room;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_room"></param>
        /// <returns>The deleted Room-Object. NULL, or Exception if an error occurs.</returns>
        public Room Delete(Room p_room)
        {
            using (var context = new FhdwHotelContext())
            {
                context.Room.Remove(p_room);
                context.SaveChanges();
            };

            return p_room;
        }
    }
}
