using System.Collections.Generic;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository.Repositories;

namespace FHDW.Hotel.BLL
{
    /// <summary>
    /// 
    /// </summary>
    public class DatabaseService
    {
        #region Dependencies
        public IDatabaseRepository DatabaseRepository;
        #endregion

        /// <summary>
        /// 
        /// </summary>
        public DatabaseService()
        {
            DatabaseRepository = new DatabaseRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        public void CreateDatabaseWithTestData()
        {
            CreateDatabase();
            AddTestDataInDatabase();
        }

        /// <summary>
        /// 
        /// </summary>
        public void CreateDatabase()
        {
            DatabaseRepository.CreateDatabase();
        }

        /// <summary>
        /// 
        /// </summary>
        public void AddTestDataInDatabase()
        {
            // Address, Admin, Bookings, Guests, Hotels, Rooms
            DatabaseRepository.InsertTestData(null, null, null, null, GetHotelTestData(), GetRoomTestData());
        }

        #region TESTDATA
        private static ICollection<DomainModel.Hotel> GetHotelTestData()
        {
            return new List<DomainModel.Hotel>
            {
                new DomainModel.Hotel
                {
                    Name = "Eins",
                    Address = new Address
                    {
                        City = "Paderborn",
                        PostalCode = "33100",
                        Street = "Fürstenallee 3-5"
                    },
                    Rooms = new List<Room>
                    {
                        new Room
                        {
                            RoomNumber = "1",
                            Category = Enums.RoomCategory.Standard,
                            Type = Enums.RoomType.Single,
                            PersonCount = 1,
                            Price = 11
                        }
                    }
                },
                new DomainModel.Hotel
                {
                    Name = "Zwei",
                    Address = new Address
                    {
                        City = "Lippstadt",
                        PostalCode = "33100",
                        Street = "Fürstenallee 3-5"
                    },
                    Rooms = new List<Room>
                    {
                        new Room
                        {
                            RoomNumber = "2",
                            Category = Enums.RoomCategory.Standard,
                            Type = Enums.RoomType.Single,
                            PersonCount = 1,
                            Price = 11
                        }
                    }
                },
                new DomainModel.Hotel
                {
                    Name = "Drei",
                    Address = new Address
                    {
                        City = "Bielefeld",
                        PostalCode = "33100",
                        Street = "Fürstenallee 3-5"
                    },
                    Rooms = new List<Room>
                    {
                        new Room
                        {
                            RoomNumber = "3",
                            Category = Enums.RoomCategory.Standard,
                            Type = Enums.RoomType.Single,
                            PersonCount = 1,
                            Price = 11
                        }
                    }
                },
                new DomainModel.Hotel
                {
                    Name = "Vier",
                    Address = new Address
                    {
                        City = "Kassel",
                        PostalCode = "33100",
                        Street = "Fürstenallee 3-5"
                    },
                    Rooms = new List<Room>
                    {
                        new Room
                        {
                            RoomNumber = "4",
                            Category = Enums.RoomCategory.Standard,
                            Type = Enums.RoomType.Single,
                            PersonCount = 1,
                            Price = 11
                        }
                    }
                }
            };
        }

        private static ICollection<Room> GetRoomTestData()
        {
            var hoteleins = new DomainModel.Hotel
            {
                ID = 1,
                Name = "Eins",
                Address = new Address
                {
                    City = "1",
                    PostalCode = "1",
                    Street = "1"
                }
            };

            return new List<Room>
            {
                #region Hotel 1
                #region Single
                new Room
                {
                    Hotel = hoteleins,
                    Category = Enums.RoomCategory.Standard,
                    Type = Enums.RoomType.Single,
                    PersonCount = 1,
                    Price = 11,
                    RoomNumber = "001"
                },
                new Room
                {
                    Hotel = hoteleins,
                    Category = Enums.RoomCategory.Comfort,
                    Type = Enums.RoomType.Single,
                    PersonCount = 1,
                    Price = 11,
                    RoomNumber = "002"
                },
                new Room
                {
                    Hotel = hoteleins,
                    Category = Enums.RoomCategory.Superior,
                    Type = Enums.RoomType.Single,
                    PersonCount = 1,
                    Price = 11,
                    RoomNumber = "003"
                },
                #endregion
                #region Double
                new Room
                {
                    Hotel = hoteleins,
                    Category = Enums.RoomCategory.Standard,
                    Type = Enums.RoomType.Double,
                    PersonCount = 1,
                    Price = 11,
                    RoomNumber = "011"
                },
                new Room
                {
                    Hotel = hoteleins,
                    Category = Enums.RoomCategory.Comfort,
                    Type = Enums.RoomType.Double,
                    PersonCount = 1,
                    Price = 11,
                    RoomNumber = "012"
                },
                new Room
                {
                    Hotel = hoteleins,
                    Category = Enums.RoomCategory.Superior,
                    Type = Enums.RoomType.Double,
                    PersonCount = 1,
                    Price = 11,
                    RoomNumber = "013"
                },
                #endregion
                #region Family
                new Room
                {
                    Hotel = hoteleins,
                    Category = Enums.RoomCategory.Standard,
                    Type = Enums.RoomType.Family,
                    PersonCount = 1,
                    Price = 11,
                    RoomNumber = "021"
                },
                new Room
                {
                    Hotel = hoteleins,
                    Category = Enums.RoomCategory.Comfort,
                    Type = Enums.RoomType.Family,
                    PersonCount = 1,
                    Price = 11,
                    RoomNumber = "022"
                },
                new Room
                {
                    Hotel = hoteleins,
                    Category = Enums.RoomCategory.Superior,
                    Type = Enums.RoomType.Family,
                    PersonCount = 1,
                    Price = 11,
                    RoomNumber = "033"
                },
                #endregion
                #endregion
                #region Hotel 2
                #region Single
                new Room
                {
                    Hotel = hoteleins,
                    Category = Enums.RoomCategory.Standard,
                    Type = Enums.RoomType.Single,
                    PersonCount = 1,
                    Price = 11,
                    RoomNumber = "001"
                },
                new Room
                {
                    Hotel = hoteleins,
                    Category = Enums.RoomCategory.Standard,
                    Type = Enums.RoomType.Single,
                    PersonCount = 1,
                    Price = 11,
                    RoomNumber = "002"
                },
                new Room
                {
                    Hotel = hoteleins,
                    Category = Enums.RoomCategory.Standard,
                    Type = Enums.RoomType.Single,
                    PersonCount = 1,
                    Price = 11,
                    RoomNumber = "003"
                },
                new Room
                {
                    Hotel = hoteleins,
                    Category = Enums.RoomCategory.Standard,
                    Type = Enums.RoomType.Single,
                    PersonCount = 1,
                    Price = 11,
                    RoomNumber = "004"
                },
                new Room
                {
                    Hotel = hoteleins,
                    Category = Enums.RoomCategory.Standard,
                    Type = Enums.RoomType.Single,
                    PersonCount = 1,
                    Price = 11,
                    RoomNumber = "005"
                },
                new Room
                {
                    Hotel = hoteleins,
                    Category = Enums.RoomCategory.Comfort,
                    Type = Enums.RoomType.Single,
                    PersonCount = 1,
                    Price = 11,
                    RoomNumber = "006"
                },
                new Room
                {
                    Hotel = hoteleins,
                    Category = Enums.RoomCategory.Superior,
                    Type = Enums.RoomType.Single,
                    PersonCount = 1,
                    Price = 11,
                    RoomNumber = "003"
                },
                #endregion
                #region Double
                new Room
                {
                    Hotel = hoteleins,
                    Category = Enums.RoomCategory.Standard,
                    Type = Enums.RoomType.Double,
                    PersonCount = 1,
                    Price = 11,
                    RoomNumber = "011"
                },
                new Room
                {
                    Hotel = hoteleins,
                    Category = Enums.RoomCategory.Comfort,
                    Type = Enums.RoomType.Double,
                    PersonCount = 1,
                    Price = 11,
                    RoomNumber = "012"
                },
                new Room
                {
                    Hotel = hoteleins,
                    Category = Enums.RoomCategory.Superior,
                    Type = Enums.RoomType.Double,
                    PersonCount = 1,
                    Price = 11,
                    RoomNumber = "013"
                }
                #endregion
                #endregion
            };
        }
        #endregion
    }
}
