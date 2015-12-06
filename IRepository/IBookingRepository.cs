using FHDW.Hotel.DomainModel;

namespace FHDW.Hotel.IRepository
{
    public interface IBookingRepository
    {
        Booking Insert(Booking p_booking);
        Booking Update(Booking p_booking);
    }
}
