using System.Collections.Generic;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;

namespace FHDW.Hotel.Repository
{
    /// <summary>
    /// Every Request returning a Hotel-Object will be handled in this Repository.
    /// </summary>
    public class HotelRepository : BaseRepository, IHotelRepository
    {
        /// <summary>
        /// Get a List of all Hotels in the database.
        /// </summary>
        /// <returns>List with all Hotels. If no Hotel exists, return an empty List.</returns>
        public ICollection<DomainModel.Hotel> GetCollection()
        {
            var hotels = getHotelTestdata();
            return hotels;
        }

        /// <summary>
        /// Get a specific Hotel.
        /// </summary>
        /// <param name="p_id">ID of the Hotel</param>
        /// <returns>The requested Hotel. If no Hotel exists, return NULL.</returns>
        public DomainModel.Hotel GetById(int p_id)
        {
            return new DomainModel.Hotel();
        }

        #region Testdata
        private ICollection<DomainModel.Hotel> getHotelTestdata()
        {
            var hotel1 = new DomainModel.Hotel
            {
                ID = 1,
                Address = new Address
                {
                    ID = 1,
                    City = "Hannover",
                    PostalCode = "12345",
                    Street = "Dieser Weg 1"
                },
                Rooms = new List<Room>
                {
                    new Room{ ID = 1, Category = Enums.RoomCategory.Standard, PersonCount = 1, Type = Enums.RoomType.Single, Price = 22, RoomNumber = "123"},
                    new Room{ ID = 2, Category = Enums.RoomCategory.Standard, PersonCount = 1, Type = Enums.RoomType.Single, Price = 22, RoomNumber = "123" },
                    new Room{ ID = 3, Category = Enums.RoomCategory.Standard, PersonCount = 2, Type = Enums.RoomType.Double, Price = 33, RoomNumber = "123" },
                    new Room{ ID = 4, Category = Enums.RoomCategory.Standard, PersonCount = 2, Type = Enums.RoomType.Double, Price = 33, RoomNumber = "123"},
                    new Room{ ID = 5, Category = Enums.RoomCategory.Standard, PersonCount = 5, Type = Enums.RoomType.Family, Price = 50, RoomNumber = "123" },
                    new Room{ ID = 6, Category = Enums.RoomCategory.Standard, PersonCount = 5, Type = Enums.RoomType.Family, Price = 50, RoomNumber = "123" },
                    new Room{ ID = 7, Category = Enums.RoomCategory.Comfort, PersonCount = 1, Type = Enums.RoomType.Single, Price = 60, RoomNumber = "123"},
                    new Room{ ID = 8, Category = Enums.RoomCategory.Comfort, PersonCount = 1, Type = Enums.RoomType.Single, Price = 60, RoomNumber = "123"},
                    new Room{ ID = 9, Category = Enums.RoomCategory.Comfort, PersonCount = 2, Type = Enums.RoomType.Double, Price = 100, RoomNumber = "123"},
                    new Room{ ID = 10, Category = Enums.RoomCategory.Comfort, PersonCount = 2, Type = Enums.RoomType.Double, Price = 100, RoomNumber = "123"},
                    new Room{ ID = 11, Category = Enums.RoomCategory.Comfort, PersonCount = 5, Type = Enums.RoomType.Family, Price = 110, RoomNumber = "123"},
                    new Room{ ID = 12, Category = Enums.RoomCategory.Comfort, PersonCount = 5, Type = Enums.RoomType.Family, Price = 110, RoomNumber = "123"},
                    new Room{ ID = 13, Category = Enums.RoomCategory.Superior, PersonCount = 1, Type = Enums.RoomType.Single, Price = 150, RoomNumber = "123"},
                    new Room{ ID = 14, Category = Enums.RoomCategory.Superior, PersonCount = 1, Type = Enums.RoomType.Single, Price = 150, RoomNumber = "123"},
                    new Room{ ID = 15, Category = Enums.RoomCategory.Superior, PersonCount = 2, Type = Enums.RoomType.Double, Price = 222, RoomNumber = "123"},
                    new Room{ ID = 16, Category = Enums.RoomCategory.Superior, PersonCount = 2, Type = Enums.RoomType.Double, Price = 222, RoomNumber = "123"},
                    new Room{ ID = 17, Category = Enums.RoomCategory.Superior, PersonCount = 5, Type = Enums.RoomType.Family, Price = 250, RoomNumber = "123"},
                    new Room{ ID = 18, Category = Enums.RoomCategory.Superior, PersonCount = 5, Type = Enums.RoomType.Family, Price = 250, RoomNumber = "123"}
                }
            };

            var hotel2 = new DomainModel.Hotel
            {
                ID = 2,
                Address = new Address
                {
                    ID = 1,
                    City = "Paderborn",
                    PostalCode = "32165",
                    Street = "Irgendwo 666"
                },
                Rooms = new List<Room>
                {
                    new Room{ ID = 1, Category = Enums.RoomCategory.Standard, PersonCount = 1, Type = Enums.RoomType.Single, Price = 22, RoomNumber = "123"},
                    new Room{ ID = 2, Category = Enums.RoomCategory.Standard, PersonCount = 1, Type = Enums.RoomType.Single, Price = 22, RoomNumber = "123" },
                    new Room{ ID = 3, Category = Enums.RoomCategory.Standard, PersonCount = 2, Type = Enums.RoomType.Double, Price = 33, RoomNumber = "123" },
                    new Room{ ID = 4, Category = Enums.RoomCategory.Standard, PersonCount = 2, Type = Enums.RoomType.Double, Price = 33, RoomNumber = "123"},
                    new Room{ ID = 5, Category = Enums.RoomCategory.Standard, PersonCount = 5, Type = Enums.RoomType.Family, Price = 50, RoomNumber = "123" },
                    new Room{ ID = 6, Category = Enums.RoomCategory.Standard, PersonCount = 5, Type = Enums.RoomType.Family, Price = 50, RoomNumber = "123" },
                    new Room{ ID = 7, Category = Enums.RoomCategory.Comfort, PersonCount = 1, Type = Enums.RoomType.Single, Price = 60, RoomNumber = "123"},
                    new Room{ ID = 8, Category = Enums.RoomCategory.Comfort, PersonCount = 1, Type = Enums.RoomType.Single, Price = 60, RoomNumber = "123"},
                    new Room{ ID = 9, Category = Enums.RoomCategory.Comfort, PersonCount = 2, Type = Enums.RoomType.Double, Price = 100, RoomNumber = "123"},
                    new Room{ ID = 10, Category = Enums.RoomCategory.Comfort, PersonCount = 2, Type = Enums.RoomType.Double, Price = 100, RoomNumber = "123"},
                    new Room{ ID = 11, Category = Enums.RoomCategory.Comfort, PersonCount = 5, Type = Enums.RoomType.Family, Price = 110, RoomNumber = "123"},
                    new Room{ ID = 12, Category = Enums.RoomCategory.Comfort, PersonCount = 5, Type = Enums.RoomType.Family, Price = 110, RoomNumber = "123"},
                    new Room{ ID = 13, Category = Enums.RoomCategory.Superior, PersonCount = 1, Type = Enums.RoomType.Single, Price = 150, RoomNumber = "123"},
                    new Room{ ID = 14, Category = Enums.RoomCategory.Superior, PersonCount = 1, Type = Enums.RoomType.Single, Price = 150, RoomNumber = "123"},
                    new Room{ ID = 15, Category = Enums.RoomCategory.Superior, PersonCount = 2, Type = Enums.RoomType.Double, Price = 222, RoomNumber = "123"},
                    new Room{ ID = 16, Category = Enums.RoomCategory.Superior, PersonCount = 2, Type = Enums.RoomType.Double, Price = 222, RoomNumber = "123"},
                    new Room{ ID = 17, Category = Enums.RoomCategory.Superior, PersonCount = 5, Type = Enums.RoomType.Family, Price = 250, RoomNumber = "123"},
                    new Room{ ID = 18, Category = Enums.RoomCategory.Superior, PersonCount = 5, Type = Enums.RoomType.Family, Price = 250, RoomNumber = "123"}
                }
            };

            return new List<DomainModel.Hotel> { hotel1, hotel2 };
        }
        #endregion
    }
}
