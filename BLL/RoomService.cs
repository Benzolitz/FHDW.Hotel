using System;
using System.Collections.Generic;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository.Repositories;

namespace FHDW.Hotel.BLL
{
    /// <summary>
    /// Handles all logical decisions for the Roomobject.
    /// </summary>
    /// <creator>Lucas Engel</creator>
    public class RoomService
    {
        #region Dependencies
        private readonly IRoomRepository _roomRepository;
        #endregion

        /// <summary>
        /// Initialize the Service.
        /// </summary>
        public RoomService()
        {
            _roomRepository = new RoomRepository();
        }

        /// <summary>
        /// Get a specific Room by ID.
        /// </summary>
        /// <param name="p_id">ID of the Room.</param>
        /// <returns>Filled Roomobject, or NULL</returns>
        public Room GetById(int p_id)
        {
            return _roomRepository.GetById(p_id);
        }

        /// <summary>
        /// Get a Collection of Rooms wich are possesed by a Hotel.
        /// </summary>
        /// <returns>Filled or empty Collection</returns>
        public ICollection<Room> GetCollectionByHotel(DomainModel.Hotel p_hotel)
        {
            return _roomRepository.GetCollectionByHotel(p_hotel);
        }

        /// <summary>
        /// Get all availble Rooms
        /// </summary>
        /// <param name="p_hotelId"></param>
        /// <param name="p_arrival"></param>
        /// <param name="p_departure"></param>
        /// <returns></returns>
        public ICollection<Room> GetAvailableRooms(int p_hotelId, DateTime p_arrival, DateTime p_departure)
        {
            return _roomRepository.GetAvailableRooms(p_hotelId, p_arrival, p_departure);
        }

        /// <summary>
        /// Insert or Update a Room depending on the ID.
        /// </summary>
        /// <param name="p_room"></param>
        /// <returns></returns>
        public Room Save(Room p_room)
        {
            return p_room.ID == 0 ? _roomRepository.Insert(p_room) : _roomRepository.Update(p_room);
        }

        /// <summary>
        /// Delete a Room.
        /// </summary>
        /// <param name="p_room"></param>
        /// <returns></returns>
        public Room Delete(Room p_room)
        {
            return _roomRepository.Delete(p_room);
        }

        /// <summary>
        /// Delete a Room.
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public Room DeleteById(int p_id)
        {
            var room = _roomRepository.GetById(p_id);
            return Delete(room);
        }
    }
}
