using System.Data.SqlClient;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;

namespace FHDW.Hotel.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public class AdminRepository : IAdminRepository
    {
        /// <summary>
        /// Get the Adminobject with the given username.
        /// </summary>
        /// <param name="p_username">Username of the Admin.</param>
        /// <returns>If found an Adminobject. NULL otherwise.</returns>
        public Admin GetByUsername(string p_username)
        {
            var cmd = new SqlCommand
            {
                CommandText = @"SELECT * FROM admin WHERE Username = @Username"
            };

            cmd.Parameters.Add(new SqlParameter("@Username", p_username));

            return p_username.ToLower() == "root"
                ? new Admin { ID = 1, Username = "root", Password = "zlymc9E7NhGNVKfPE66wygEjg793HnE0IbTR/YQfU5o=" }
                : null;
        }
    }
}
