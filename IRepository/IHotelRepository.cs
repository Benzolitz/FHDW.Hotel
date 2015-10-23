using System.Collections.Generic;

namespace FHDW.Hotel.IRepository
{
    /// <summary>
    /// 
    /// </summary>
    public interface IHotelRepository
    {
        ICollection<DomainModel.Hotel> Get();
    }
}
