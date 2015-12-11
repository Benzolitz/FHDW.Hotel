using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository.Database;

namespace FHDW.Hotel.Repository.Repositories
{
    /// <summary>
    /// Repository for all Hotel-related queries. 
    /// </summary>
    /// <author>Viktoria Pierenkemper, Lucas Engel</author>
    public class HotelRepository : IHotelRepository
    {
        /// <summary>
        /// Get a List of all Hotels in the database.
        /// </summary>
        /// <returns>List with all Hotels. If no Hotel exists, return an empty List.</returns>
        public ICollection<DomainModel.Hotel> GetCollection()
        {
            using (var context = new FhdwHotelContext())
            {
                return context.Hotel.Include(h => h.Address).ToList();
            }
        }

        /// <summary>
        /// Get a specific Hotel.
        /// </summary>
        /// <param name="p_id">ID of the Hotel</param>
        /// <returns>The requested Hotel. If no Hotel exists, return NULL.</returns>
        public DomainModel.Hotel GetById(int p_id)
        {
            using (var context = new FhdwHotelContext())
            {
                return context.Hotel.Include(a => a.Address).FirstOrDefault(h => h.ID == p_id);
            }
        }
    }
}
