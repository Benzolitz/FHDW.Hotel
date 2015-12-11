using FHDW.Hotel.DomainModel;

namespace FHDW.Hotel.IRepository
{
    /// <summary>
    /// Interface for all Admin-Queries.
    /// </summary>
    /// <author>Lucas Engel</author>
    public interface IAdminRepository
    {
        /// <summary>
        /// Request an Admin-Object from the Database, with the username.
        /// </summary>
        /// <param name="p_username">Username of the Administrator.</param>
        /// <returns>The found Adminobject will be returned. If no Admin was found, NULL will be returned. </returns>
        Admin GetByUsername(string p_username);
    }
}
