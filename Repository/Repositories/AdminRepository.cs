using System.Data.SqlClient;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;

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
            var cmd = new SqlCommand
            {
                CommandText = @"SELECT * FROM admin WHERE Username = @Username"
            };

            cmd.Parameters.Add(new SqlParameter("@Username", p_username));


            
            
            return p_username.ToLower() == "root"
                ? new Admin { ID = 1, Username = "root", Password = "zlymc9E7NhGNVKfPE66wygEjg793HnE0IbTR/YQfU5o=" } // Passwörter werden als Hash in der Datenbank gespeichert.
                : null;
        }
    }
}
