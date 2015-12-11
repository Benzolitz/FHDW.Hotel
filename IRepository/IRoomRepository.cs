using System;
using System.Collections.Generic;
using FHDW.Hotel.DomainModel;

namespace FHDW.Hotel.IRepository
{
    /// <summary>
    /// Interface for all Room-Queries.
    /// </summary>
    /// <author>Lucas Engel</author>
    public interface IRoomRepository
    {
        /// <summary>
        /// Get a specific Room by ID.
        /// </summary>
        /// <param name="p_id">ID of the Room.</param>
        /// <returns>The requested Hotel. If no Hotel exists, return NULL.</returns>
        Room GetById(int p_id);

        /// <summary>
        /// Get a Collection of all Rooms from one Hotel
        /// </summary>
        /// <param name="p_hotel">Hotelobject with an ID set</param>
        /// <returns>Collection of Rooms.</returns>
        ICollection<Room> GetCollectionByHotel(DomainModel.Hotel p_hotel);

        /// <summary>
        /// Get a List of all Rooms, wich are not already booked in a specific timeframe.
        /// </summary>
        /// <param name="p_hotelId"></param>
        /// <param name="p_arrival">The Arrivaldate of the Guest.</param>
        /// <param name="p_departure">The Departuredate of the Guest.</param>
        /// <returns>List with all Rooms. If no Room exists, return an empty List.</returns>
        ICollection<Room> GetAvailableRooms(int p_hotelId, DateTime p_arrival, DateTime p_departure);

        /// <summary>
        /// Insert a new Room into the databse.
        /// </summary>
        /// <param name="p_room">The new Room.</param>
        /// <returns>The Newly created Room-Object. NULL, or Exception if an error occurs.</returns>
        Room Insert(Room p_room);

        /// <summary>
        /// Update an existing Room in the Database.
        /// </summary>
        /// <param name="p_room">Room to Update.</param>
        /// <returns>The updated Room-Object. NULL, or Exception if an error occurs.</returns>
        Room Update(Room p_room);

        /// <summary>
        /// Delete a room from the database.
        /// </summary>
        /// <param name="p_room">Roomobject with the ID set.</param>
        /// <returns>The deleted Room-Object. NULL, or Exception if an error occurs.</returns>
        Room Delete(Room p_room);
    }
}
