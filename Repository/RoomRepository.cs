﻿using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;

namespace FHDW.Hotel.Repository
{
    /// <summary>
    /// Every Request returning a Room-Object will be handled in this Repository.
    /// </summary>
    public class RoomRepository : BaseRepository, IRoomRepository
    {
        /// <summary>
        /// Get a specific Room by ID.
        /// </summary>
        /// <param name="p_id">ID of the Room.</param>
        /// <returns>The requested Hotel. If no Hotel exists, return NULL.</returns>
        public Room GetById(int p_id)
        {
            var cmd = new SqlCommand
            {
                CommandText = @"SELECT * FROM room WHERE ID = @ID"
            };

            cmd.Parameters.Add(new SqlParameter("@ID", p_id));
            return new Room();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_hotel"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public ICollection<Room> GetCollectionByHotel(DomainModel.Hotel p_hotel)
        {
            return getTestData(p_hotel);
        }

        /// <summary>
        /// Get a List of all Rooms, wich are not already booked in a specific timeframe.
        /// </summary>
        /// <param name="p_hotelId"></param>
        /// <param name="p_arrival">The Arrivaldate of the Guest.</param>
        /// <param name="p_departure">The Departuredate of the Guest.</param>
        /// <returns>List with all Rooms. If no Room exists, return an empty List.</returns>
        public ICollection<Room> GetAvailableRooms(int p_hotelId, DateTime p_arrival, DateTime p_departure)
        {
            var cmd = new SqlCommand
            {
                CommandText = @"SELECT * FROM room 
                                WHERE HotelID = @Hotelid AND
                                      booking.Arrival = @Arrival AND
                                      booking.Departure = @Departure"

            };

            cmd.Parameters.Add(new SqlParameter("@HotelID", p_hotelId));
            cmd.Parameters.Add(new SqlParameter("@Arrival", p_arrival));
            cmd.Parameters.Add(new SqlParameter("@Departure", p_departure));

            return new List<Room>();
        }

        /// <summary>
        /// Insert a new Room into the databse.
        /// </summary>
        /// <param name="p_room">The new Room.</param>
        /// <returns>The Newly created Room-Object. NULL, or Exception if an error occurs.</returns>
        public Room Insert(Room p_room)
        {
            var cmd = new SqlCommand
            {
                CommandText = @"INSERT INTO room (ID, RoomNumber, Price, HotelID, TypeID, CategoryID)
                                VALUES (@ID, @RoomNumber, @Price, @HotelID, @TypeID, @CategoryID)"
            };

            cmd.Parameters.Add(new SqlParameter("@ID, @RoomNumber, @Price, @HotelID, @TypeID, @CategoryID", p_room));

            return new Room();
        }

        /// <summary>
        /// Update an existing Room in the Database.
        /// </summary>
        /// <param name="p_room">Room to Update.</param>
        /// <returns>The updated Room-Object. NULL, or Exception if an error occurs.</returns>
        public Room Update(Room p_room)
        {
            var cmd = new SqlCommand
            {
                CommandText = @"UPDATE room
	                            SET RoomNumber =@RoomNumber, 
                                    Price = @Price, 
                                    HotelID = @HotelID, 
                                    TypeID = @TypeID, 
                                    CategoryID = @CategoryID
                                    
	                                WHERE ID = @ID"
            };

            cmd.Parameters.Add(new SqlParameter("@ID, @RoomNumber, @Price, @HotelID, @TypeID, @CategoryID", p_room));

            return new Room();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns>The deleted Room-Object. NULL, or Exception if an error occurs.</returns>
        public Room Delete(Room p_id)
        {
            var cmd = new SqlCommand
            {
                CommandText = @"DELETE FROM room 
                                WHERE ID = @ID"
            };

            cmd.Parameters.Add(new SqlParameter("@id", p_id));
            //Ich hab das hier mal geändert in p_id da hier doch anhand der id gelöscht wird also nicht über p_room ==> Prüfen bitte?
            return new Room();
        }

        #region TestData!
        private ICollection<Room> getTestData(DomainModel.Hotel p_hotel)
        {
            return new List<Room>
            {
                new Room
                {
                    ID = 1,
                    Category = Enums.RoomCategory.Standard,
                    PersonCount = 1,
                    Type = Enums.RoomType.Single,
                    Price = 22,
                    RoomNumber = "123"
                },
                new Room
                {
                    ID = 2,
                    Category = Enums.RoomCategory.Standard,
                    PersonCount = 1,
                    Type = Enums.RoomType.Single,
                    Price = 22,
                    RoomNumber = "123"
                },
                new Room
                {
                    ID = 3,
                    Category = Enums.RoomCategory.Standard,
                    PersonCount = 2,
                    Type = Enums.RoomType.Double,
                    Price = 33,
                    RoomNumber = "123"
                },
                new Room
                {
                    ID = 4,
                    Category = Enums.RoomCategory.Standard,
                    PersonCount = 2,
                    Type = Enums.RoomType.Double,
                    Price = 33,
                    RoomNumber = "123"
                },
                new Room
                {
                    ID = 5,
                    Category = Enums.RoomCategory.Standard,
                    PersonCount = 5,
                    Type = Enums.RoomType.Family,
                    Price = 50,
                    RoomNumber = "123"
                },
                new Room
                {
                    ID = 6,
                    Category = Enums.RoomCategory.Standard,
                    PersonCount = 5,
                    Type = Enums.RoomType.Family,
                    Price = 50,
                    RoomNumber = "123"
                },
                new Room
                {
                    ID = 7,
                    Category = Enums.RoomCategory.Comfort,
                    PersonCount = 1,
                    Type = Enums.RoomType.Single,
                    Price = 60,
                    RoomNumber = "123"
                },
                new Room
                {
                    ID = 8,
                    Category = Enums.RoomCategory.Comfort,
                    PersonCount = 1,
                    Type = Enums.RoomType.Single,
                    Price = 60,
                    RoomNumber = "123"
                },
                new Room
                {
                    ID = 9,
                    Category = Enums.RoomCategory.Comfort,
                    PersonCount = 2,
                    Type = Enums.RoomType.Double,
                    Price = 100,
                    RoomNumber = "123"
                },
                new Room
                {
                    ID = 10,
                    Category = Enums.RoomCategory.Comfort,
                    PersonCount = 2,
                    Type = Enums.RoomType.Double,
                    Price = 100,
                    RoomNumber = "123"
                },
                new Room
                {
                    ID = 11,
                    Category = Enums.RoomCategory.Comfort,
                    PersonCount = 5,
                    Type = Enums.RoomType.Family,
                    Price = 110,
                    RoomNumber = "123"
                },
                new Room
                {
                    ID = 12,
                    Category = Enums.RoomCategory.Comfort,
                    PersonCount = 5,
                    Type = Enums.RoomType.Family,
                    Price = 110,
                    RoomNumber = "123"
                },
                new Room
                {
                    ID = 13,
                    Category = Enums.RoomCategory.Superior,
                    PersonCount = 1,
                    Type = Enums.RoomType.Single,
                    Price = 150,
                    RoomNumber = "123"
                },
                new Room
                {
                    ID = 14,
                    Category = Enums.RoomCategory.Superior,
                    PersonCount = 1,
                    Type = Enums.RoomType.Single,
                    Price = 150,
                    RoomNumber = "123"
                },
                new Room
                {
                    ID = 15,
                    Category = Enums.RoomCategory.Superior,
                    PersonCount = 2,
                    Type = Enums.RoomType.Double,
                    Price = 222,
                    RoomNumber = "123"
                },
                new Room
                {
                    ID = 16,
                    Category = Enums.RoomCategory.Superior,
                    PersonCount = 2,
                    Type = Enums.RoomType.Double,
                    Price = 222,
                    RoomNumber = "123"
                },
                new Room
                {
                    ID = 17,
                    Category = Enums.RoomCategory.Superior,
                    PersonCount = 5,
                    Type = Enums.RoomType.Family,
                    Price = 250,
                    RoomNumber = "123"
                },
                new Room
                {
                    ID = 18,
                    Category = Enums.RoomCategory.Superior,
                    PersonCount = 5,
                    Type = Enums.RoomType.Family,
                    Price = 250,
                    RoomNumber = "123"
                }
            };
        }
        #endregion
    }
}
