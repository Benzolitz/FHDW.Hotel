using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository.Database;
using MySql.Data.MySqlClient;

namespace FHDW.Hotel.Repository.Repositories
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
            return getHotelTestdata();
        }

        /// <summary>
        /// Get a specific Hotel.
        /// </summary>
        /// <param name="p_id">ID of the Hotel</param>
        /// <returns>The requested Hotel. If no Hotel exists, return NULL.</returns>
        /// <creator>Viktoria Pierenkemper</creator>
        public DomainModel.Hotel GetById(int p_id)
        {
            var cmd = new SqlCommand
            {
                CommandText = @"SELECT * FROM hotel WHERE ID = @ID"
            };

            cmd.Parameters.Add(new SqlParameter("@ID", p_id));

            return new DomainModel.Hotel();
        }

        #region Testdata
        private ICollection<DomainModel.Hotel> getHotelTestdata()
        {
            var hotel1 = new DomainModel.Hotel
            {
                ID = 1,
                Name = "Keine Ahnung",
                Address = new Address
                {
                    ID = 1,
                    City = "Hannover",
                    PostalCode = "12345",
                    Street = "Dieser Weg 1"
                }
            };

            var hotel2 = new DomainModel.Hotel
            {
                ID = 2,
                Name = "Hotel Eins",
                Address = new Address
                {
                    ID = 1,
                    City = "Paderborn",
                    PostalCode = "32165",
                    Street = "Irgendwo 666"
                }
            };

            return new List<DomainModel.Hotel> { hotel1, hotel2 };
        }
        #endregion
    }
}
