using System;
using System.Collections.Generic;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository;

namespace FHDW.Hotel.BLL
{
    /// <summary>
    /// Handle all Requests for the Room.
    /// </summary>
    /// <creator>Lucas Engel</creator>
    public class RoomService
    {
        #region Dependencies
        private IRoomRepository RoomRepository { get; set; }
        #endregion

        /// <summary>
        /// Initialize the RoomService.
        /// </summary>
        public RoomService()
        {
            RoomRepository = new RoomRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public Room GetById(int p_id)
        {
            return RoomRepository.GetById(p_id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_hotelId"></param>
        /// <param name="p_arrival"></param>
        /// <param name="p_departure"></param>
        /// <returns></returns>
        public ICollection<Room> GetAvailableRooms(int p_hotelId, DateTime p_arrival, DateTime p_departure)
        {
            return RoomRepository.GetAvailableRooms(p_hotelId, p_arrival, p_departure);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_room"></param>
        /// <returns></returns>
        public Room Save(Room p_room)
        {
            return p_room.ID == 0 ? RoomRepository.Insert(p_room) : RoomRepository.Update(p_room);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_room"></param>
        /// <returns></returns>
        public Room Delete(Room p_room)
        {
            return RoomRepository.Delete(p_room);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public Room DeleteById(int p_id)
        {
            var room = RoomRepository.GetById(p_id);
            return Delete(room);
        }
    }
}
