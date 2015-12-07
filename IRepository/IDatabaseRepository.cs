using System.Collections.Generic;
using FHDW.Hotel.DomainModel;

namespace FHDW.Hotel.IRepository
{
    public interface IDatabaseRepository
    {
        void CreateDatabase();
        void InsertTestData(ICollection<Address> p_addresses, ICollection<Admin> p_admins, ICollection<Booking> p_bookings, ICollection<Guest> p_guests, ICollection<DomainModel.Hotel> p_hotels, ICollection<Room> p_rooms);
    }
}
