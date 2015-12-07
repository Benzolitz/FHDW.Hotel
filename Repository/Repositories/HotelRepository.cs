using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository.Database;
using NHibernate.Util;

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
            using (var connection = base.currentConnection)
            {
                connection.Open();
                
                using (var context = new FhdwHotelContext(connection, false))
                {
                    return context.Hotel.Include(h => h.Address).ToList();
                }
            }
        }

        /// <summary>
        /// Get a specific Hotel.
        /// </summary>
        /// <param name="p_id">ID of the Hotel</param>
        /// <returns>The requested Hotel. If no Hotel exists, return NULL.</returns>
        /// <creator>Viktoria Pierenkemper</creator>
        public DomainModel.Hotel GetById(int p_id)
        {
            using (var connection = base.currentConnection)
            {
                connection.Open();

                using (var context = new FhdwHotelContext(connection, false))
                {
                    return context.Hotel.Include(h => h.Address).First(h => h.ID == p_id);
                }
            }
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
