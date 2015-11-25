using System.Collections.Generic;
using FHDW.Hotel.DomainModel;

namespace FHDW.Hotel.IRepository
{
    /// <summary>
    /// 
    /// </summary>
    public interface IBookingRepository
    {
        ICollection<Booking> GetCollection();
        ICollection<Booking> GetByGuestId(int p_guestId);
        Booking GetById(int p_id);
    }
}
