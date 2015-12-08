using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository.Database;

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
                    /*
                    Hole alle Hotels (context.Hotel) mit ihren Adressen (Include(...)) und wandel das Ergebniss in eine Liste (ToList()).
                    */
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
                    /*
                    Wir möchten einen Datensatz aus der Tabelle Hotel (context.Hotel), der die Adresse beinhaltet (Include(...)), aber nur den ersten der mit der übergebenen ID übereinstimmt.
                    */
                    return context.Hotel.Include(h => h.Address).First(h => h.ID == p_id);
                }
            }
        }
    }
}
