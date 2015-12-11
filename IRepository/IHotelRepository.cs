using System.Collections.Generic;

namespace FHDW.Hotel.IRepository
{
    /// <summary>
    /// Interface for all Hotel-Queries.
    /// </summary>
    /// <author>Lucas Engel</author>
    public interface IHotelRepository
    {
        /// <summary>
        /// Get a List of all Hotels in the database.
        /// </summary>
        /// <returns>List with all Hotels. If no Hotel exists, return an empty List.</returns>
        ICollection<DomainModel.Hotel> GetCollection();

        /// <summary>
        /// Get a specific Hotel.
        /// </summary>
        /// <param name="p_id">ID of the Hotel</param>
        /// <returns>The requested Hotel. If no Hotel exists, return NULL.</returns>
        DomainModel.Hotel GetById(int p_id);
    }
}
