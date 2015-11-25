using System;
using System.Collections.Generic;
using FHDW.Hotel.DomainModel;

namespace FHDW.Hotel.IRepository
{
    /// <summary>
    /// 
    /// </summary>
    public interface IRoomRepository
    {
        ICollection<Room> GetCollection();
        ICollection<Room> GetByType(Enums.RoomType p_type);
        ICollection<Room> GetByCategory(Enums.RoomCategory p_category);
        ICollection<Room> GetAvailableRooms(DateTime p_arrival, DateTime p_departure);
        ICollection<Room> GetByHotelId(int p_id);

        Room GetById(int p_id);

        Room Insert(Room p_room);
        Room Update(Room p_room);
        Room Delete(Room p_room);
    }
}
