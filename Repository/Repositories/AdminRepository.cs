using System.Data.SqlClient;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository.Database;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace FHDW.Hotel.Repository.Repositories
{
    /// <summary>
    /// Every Request returning an Admin-Object will be handled in this Repository.
    /// </summary>
    public class AdminRepository : IAdminRepository
    {
        /// <summary>
        /// Request an Admin-Object from the Database, with the username.
        /// </summary>
        /// <param name="p_username">Username of the Administrator.</param>
        /// <returns>The found Adminobject will be returned. If no Admin was found, NULL will be returned. </returns>
        public Admin GetByUsername(string p_username)
        {
            using (var context = new FhdwHotelContext())
            {
                return context.Admin.SingleOrDefault(a => a.Username.ToLower() == p_username.ToLower());
            }
        }
    }
}
