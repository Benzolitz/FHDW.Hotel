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
    }
}
