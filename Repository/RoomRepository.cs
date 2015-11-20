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
        public ICollection<Room> GetCollection()
        {
            return new List<Room>
            {
                new Room
                {
                    Category = Enums.RoomCategory.Standard,
                    Hotel = new DomainModel.Hotel { ID = 2, Address = new Address { City = "Test", ID = 1 } },
                    ID = 2,
                    PersonCount = 4,
                    Price = 555.11f,
                    Type = Enums.RoomType.Family
                },
                new Room
                {
                    Category = Enums.RoomCategory.Superior,
                    Hotel = new DomainModel.Hotel { ID = 2, Address = new Address { City = "Test", ID = 1 } },
                    ID = 4,
                    PersonCount = 2,
                    Price = 123456,
                    Type = Enums.RoomType.Doubble
                }
            };
        }
    }
}
