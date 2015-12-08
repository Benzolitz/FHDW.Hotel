using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
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
            DatabaseRepository.InsertTestData(GetAddressTestData(), GetAdminTestData(), null, GetGuestTestData(), GetHotelTestData(), GetRoomTestData());
        }

        #region TESTDATA
        private static ICollection<Address> GetAddressTestData()
        {
            return new List<Address>
            {
                new Address
                    {
                        City = "Paderborn",
                        PostalCode = "33100",
                        Street = "Fürstenallee 3-5"
                    },
                new Address
                    {
                        City = "Lippstadt",
                        PostalCode = "59557",
                        Street = "Konrad-Adenauer-Ring 22"
                    },
                new Address
                    {
                        City = "Bielefeld",
                        PostalCode = "33602",
                        Street = "Irgendwostraße 5"
                    },
                new Address
                    {
                        City = "Kassel",
                        PostalCode = "34117",
                        Street = "Hier und da Weg 666"
                    },
                new Address
                    {
                        City = "Bad Westernkotten",
                        PostalCode = "59597",
                        Street = "Testweg 1"
                    }
            };
        }

        private static ICollection<Admin> GetAdminTestData()
        {
            return new List<Admin>
            {
                new Admin
                {
                    Username = "root",
                    Password = Convert.ToBase64String(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes("toor")))
                }
            };
        }

        private static ICollection<Guest> GetGuestTestData()
        {
            return new List<Guest>
            {
                new Guest
                {
                    ContactAddress = new Address { ID = 5 },
                    Birthday = new DateTime(1991, 6, 21),
                    Birthplace = "Dort",
                    Emailaddress = "lucas@engel.de",
                    Firstname = "Lucas",
                    Lastname = "Engel",
                    Password = Convert.ToBase64String(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes("123456"))),
                    Telephone = "+49 123456789"
                }
            };
        }

        private static ICollection<DomainModel.Hotel> GetHotelTestData()
        {
            return new List<DomainModel.Hotel>
            {
                new DomainModel.Hotel
                {
                    Name = "Eins",
                    Address = new Address { ID = 1 }
                },
                new DomainModel.Hotel
                {
                    Name = "Zwei",
                    Address = new Address { ID = 2 }
                },
                new DomainModel.Hotel
                {
                    Name = "Drei",
                    Address = new Address { ID = 3 }
                },
                new DomainModel.Hotel
                {
                    Name = "Vier",
                    Address = new Address { ID = 4 }
                }
            };
        }

        private static ICollection<Room> GetRoomTestData()
        {
            var hotelEins = new DomainModel.Hotel { ID = 1 };
            var hotelZwei = new DomainModel.Hotel { ID = 2 };
            var hotelDrei = new DomainModel.Hotel { ID = 3 };
            var hotelVier = new DomainModel.Hotel { ID = 4 };

            var rooms = new List<Room>();

            for (var i = 0; i < 4; i++)
            {
                for (var j = 2; j < 20; j++)
                {
                    rooms.Add(new Room
                    {
                        Hotel = i == 1 ? hotelEins : i == 2 ? hotelZwei : i == 3 ? hotelDrei : hotelVier,
                        Category = Enums.RoomCategory.Standard,
                        Type = j % 2 == 0 ? Enums.RoomType.Single : j % 3 == 0 ? Enums.RoomType.Double : Enums.RoomType.Family,
                        PersonCount = j % 2 == 0 ? 1 : j % 3 == 0 ? 2 : 6,
                        Price = j % 2 == 0 ? 11.11f : j % 3 == 0 ? 22.22f : 30f,
                        RoomNumber = String.Format("0{0}{1}", i, j)
                    });
                }
            }

            return rooms;
        }
        #endregion
    }
}
