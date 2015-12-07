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
            DatabaseRepository.InsertTestData(null, null, null, null, GetHotelTestData(), null);
        }

        #region TESTDATA
        private static ICollection<DomainModel.Hotel> GetHotelTestData()
        {
            return new List<DomainModel.Hotel>
            {
                new DomainModel.Hotel
                {
                    Name = "Keine Ahnung",
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
                    Name = "Keine Ahnung",
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
                    Name = "Keine Ahnung",
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
                    Name = "Keine Ahnung",
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
        #endregion
    }
}
