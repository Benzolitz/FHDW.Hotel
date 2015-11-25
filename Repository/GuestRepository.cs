using System.Collections.Generic;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;

namespace FHDW.Hotel.Repository
{
    /// <summary>
    /// Every Request returning a <seealso cref="Guest">Guest</seealso>-Object will be handled in this Repository.
    /// </summary>
    public class GuestRepository : BaseRepository, IGuestRepository
    {
        /// <summary>
        /// Get a List of all Guests in the database.
        /// </summary>
        /// <returns>List with all Guests. If no Guests exists, return an empty List.</returns>
        public ICollection<Guest> GetCollection()
        {
            return new List<Guest>();
        }

        /// <summary>
        /// Get a specific Guest.
        /// </summary>
        /// <param name="p_id">ID of the Guest</param>
        /// <returns>The requested Guest. If no Guest exists, return NULL.</returns>
        public Guest GetById(int p_id)
        {
            return new Guest();
        }

        /// <summary>
        /// Get a specific Guest by their Emailaddress.
        /// </summary>
        /// <param name="p_email">Emailaddress of the Guest.</param>
        /// <returns>The requested Guest. If no Guest exists, return NULL.</returns>
        public Guest GetByEmail(string p_email)
        {
            return new Guest();
        }

        /// <summary>
        /// Insert a new Guest into the database.
        /// </summary>
        /// <param name="p_guest">The new Guest.</param>
        /// <returns>The Newly created Guest. NULL, or Exception if an error occurs.</returns>
        public Guest Insert(Guest p_guest)
        {
            return new Guest();
        }

        /// <summary>
        /// Update an existing Guest in the databse.
        /// </summary>
        /// <param name="p_guest">New Guest-Object.</param>
        /// <returns>The updated Guest-Object. NULL, or Exception if an error occurs.</returns>
        public Guest Update(Guest p_guest)
        {
            return new Guest();
        }
    }
}