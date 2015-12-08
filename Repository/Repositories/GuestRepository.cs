using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository.Database;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;

namespace FHDW.Hotel.Repository.Repositories
{
    /// <summary>
    /// Every Request returning a Guest-Object will be handled in this Repository.
    /// </summary>
    public class GuestRepository : IGuestRepository
    {
        /// <summary>
        /// Get a specific Guest by their Emailaddress.
        /// </summary>
        /// <param name="p_email">Emailaddress of the Guest.</param>
        /// <returns>The requested Guest. If no Guest exists, return NULL.</returns>
        /// <creator>Viktoria Pierenkemper</creator>
        public Guest GetByEmail(string p_email)
        {
            using (var context = new FhdwHotelContext())
            {
                /*
                Wir möchten einen Datensatz aus der Tabelle Guest (context.Guest), der die EmailAdresse beinhaltet (Include(...)), aber nur den der mit der übergebenen EmailAdresse übereinstimmt.
                */
                return context.Guest.Include(h => h.Emailaddress).First(h => h.Emailaddress == p_email);
            }
        }

        /// <summary>
        /// Insert a new Guest into the database.
        /// </summary>
        /// <param name="p_guest">The new Guest.</param>
        /// <returns>The Newly created Guest. NULL, or Exception if an error occurs.</returns>
        /// <creator>Viktoria Pierenkemper</creator>
        public DomainModel.Guest Insert(DomainModel.Guest p_guest)
        {
            using (var context = new FhdwHotelContext())
            {


                context.Guest.Add(p_guest);
                context.SaveChanges();
            };

            return p_guest;
        }

        /// <summary>
        /// Update an existing Guest in the databse.
        /// </summary>
        /// <param name="p_guest">New Guest-Object.</param>
        /// <returns>The updated Guest-Object. NULL, or Exception if an error occurs.</returns>
        /// <creator>Viktoria Pierenkemper</creator>
        public Guest Update(Guest p_guest)
        {
            using (var context = new FhdwHotelContext())
            {
                var address = context.Address.SingleOrDefault(h => h.ID == p_guest.ContactAddress.ID);        
                p_guest.ContactAddress = address;

                context.Guest.Add(p_guest);
                context.SaveChanges();
            };

            return p_guest;
        }
    }
}