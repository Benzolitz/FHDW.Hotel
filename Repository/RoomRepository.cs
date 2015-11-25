using System;
using System.Collections.Generic;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;

namespace FHDW.Hotel.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public class RoomRepository : IRoomRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ICollection<Room> GetCollection()
        {
            return new List<Room>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_type"></param>
        /// <returns></returns>
        public ICollection<Room> GetByType(Enums.RoomType p_type)
        {
            return new List<Room>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_category"></param>
        /// <returns></returns>
        public ICollection<Room> GetByCategory(Enums.RoomCategory p_category)
        {
            return new List<Room>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_arrival"></param>
        /// <param name="p_departure"></param>
        /// <returns></returns>
        public ICollection<Room> GetAvailableRooms(DateTime p_arrival, DateTime p_departure)
        {
            return new List<Room>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public ICollection<Room> GetByHotelId(int p_id)
        {
            return new List<Room>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public Room GetById(int p_id)
        {
            return new Room();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_room"></param>
        /// <returns></returns>
        public Room Insert(Room p_room)
        {
            return new Room();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_room"></param>
        /// <returns></returns>
        public Room Update(Room p_room)
        {
            return new Room();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_room"></param>
        /// <returns></returns>
        public Room Delete(Room p_room)
        {
            return new Room();
        }
    }
}
