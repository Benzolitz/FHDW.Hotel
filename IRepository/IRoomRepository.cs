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
        Room GetById(int p_id);

        ICollection<Room> GetAvailableRooms(int p_hotelId, DateTime p_arrival, DateTime p_departure);

        Room Insert(Room p_room);
        Room Update(Room p_room);
        Room Delete(Room p_room);
    }
}
