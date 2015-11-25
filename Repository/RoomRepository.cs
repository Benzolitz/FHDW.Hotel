using System;
using System.Collections.Generic;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;

namespace FHDW.Hotel.Repository
{
    /// <summary>
    /// Every Request returning a Room-Object will be handled in this Repository.
    /// </summary>
    public class RoomRepository : BaseRepository, IRoomRepository
    {
        /// <summary>
        /// Get a List of all Rooms in the database.
        /// </summary>
        /// <returns>List with all Rooms. If no Room exists, return an empty List.</returns>
        public ICollection<Room> GetCollection()
        {
            return new List<Room>();
        }

        /// <summary>
        /// Get a List of all Rooms with a specific Type.
        /// </summary>
        /// <param name="p_type">Type of the requested Rooms.</param>
        /// <returns>List with all Rooms. If no Room exists, return an empty List.</returns>
        public ICollection<Room> GetByType(Enums.RoomType p_type)
        {
            return new List<Room>();
        }

        /// <summary>
        /// Get a List of all Rooms with a specific Category.
        /// </summary>
        /// <param name="p_category">Category of the requested Rooms.</param>
        /// <returns>List with all Rooms. If no Room exists, return an empty List.</returns>
        public ICollection<Room> GetByCategory(Enums.RoomCategory p_category)
        {
            return new List<Room>();
        }

        /// <summary>
        /// Get a List of all Rooms, wich are not already booked in a specific timeframe.
        /// </summary>
        /// <param name="p_arrival">The Arrivaldate of the Guest.</param>
        /// <param name="p_departure">The Departuredate of the Guest.</param>
        /// <returns>List with all Rooms. If no Room exists, return an empty List.</returns>
        public ICollection<Room> GetAvailableRooms(DateTime p_arrival, DateTime p_departure)
        {
            return new List<Room>();
        }

        /// <summary>
        /// Get a List of all Rooms wich are located in a specific Hotel.
        /// </summary>
        /// <param name="p_id">ID the Hotel.</param>
        /// <returns>List with all Rooms. If no Room exists, return an empty List.</returns>
        public ICollection<Room> GetByHotelId(int p_id)
        {
            return new List<Room>();
        }

        /// <summary>
        /// Get a specific Room by ID.
        /// </summary>
        /// <param name="p_id">ID of the Room.</param>
        /// <returns>The requested Hotel. If no Hotel exists, return NULL.</returns>
        public Room GetById(int p_id)
        {
            return new Room();
        }

        /// <summary>
        /// Insert a new Room into the databse.
        /// </summary>
        /// <param name="p_room">The new Room.</param>
        /// <returns>The Newly created Room-Object. NULL, or Exception if an error occurs.</returns>
        public Room Insert(Room p_room)
        {
            return new Room();
        }

        /// <summary>
        /// Update an existing Room in the Database.
        /// </summary>
        /// <param name="p_room">Room to Update.</param>
        /// <returns>The updated Room-Object. NULL, or Exception if an error occurs.</returns>
        public Room Update(Room p_room)
        {
            return new Room();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_room"></param>
        /// <returns>The deleted Room-Object. NULL, or Exception if an error occurs.</returns>
        public Room Delete(Room p_room)
        {
            return new Room();
        }
    }
}
