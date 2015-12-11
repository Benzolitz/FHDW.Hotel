using System;
using System.Data.Entity;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository.Database;
using System.Linq;

namespace FHDW.Hotel.Repository.Repositories
{
    /// <summary>
    /// Repository for all Guest-related queries. 
    /// </summary>
    /// <author>Viktoria Pierenkemper, Lucas Engel</author>
    public class GuestRepository : IGuestRepository
    {
        /// <summary>
        /// Get a specific Guest by their Emailaddress.
        /// </summary>
        /// <param name="p_email">Emailaddress of the Guest.</param>
        /// <returns>The requested Guest. If no Guest exists, return NULL.</returns>
        public Guest GetByEmail(string p_email)
        {
            using (var context = new FhdwHotelContext())
            {
                return context.Guest
                    .Include(g => g.ContactAddress)
                    .Include(g=> g.BillingAddress)
                    .SingleOrDefault(g => g.Emailaddress.ToLower() == p_email.ToLower());
            }
        }

        /// <summary>
        /// Insert a new Guest into the database.
        /// </summary>
        /// <param name="p_guest">The new Guest.</param>
        /// <returns>The Newly created Guest. NULL, or Exception if an error occurs.</returns>
        public Guest Insert(Guest p_guest)
        {
            using (var context = new FhdwHotelContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        if (p_guest.ContactAddress.ID != 0) p_guest.ContactAddress = context.Address.SingleOrDefault(a => a.ID == p_guest.ContactAddress.ID);
                        if (p_guest.BillingAddress != null && p_guest.BillingAddress.ID != 0) p_guest.BillingAddress = context.Address.SingleOrDefault(a => a.ID == p_guest.BillingAddress.ID);

                        context.Guest.Add(p_guest);
                        context.SaveChanges();
                        transaction.Commit();

                        return p_guest;
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine(ex.Message);
                        transaction.Rollback();
                        return null;
                    }
                }
            }
        }

        /// <summary>
        /// Update an existing Guest in the databse.
        /// </summary>
        /// <param name="p_guest">New Guest-Object.</param>
        /// <returns>The updated Guest-Object. NULL, or Exception if an error occurs.</returns>
        public Guest Update(Guest p_guest)
        {
            using (var context = new FhdwHotelContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        p_guest.ContactAddress = context.Address.SingleOrDefault(a => a.ID == p_guest.ContactAddress.ID);
                        p_guest.BillingAddress = context.Address.SingleOrDefault(a => a.ID == p_guest.BillingAddress.ID);

                        context.Guest.Add(p_guest);
                        context.SaveChanges();
                        transaction.Commit();

                        return p_guest;
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine(ex.Message);
                        transaction.Rollback();
                        return null;
                    }
                }
            }
        }
    }
}