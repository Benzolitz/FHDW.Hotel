using System;
using System.Security.Cryptography;
using System.Text;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository;

namespace FHDW.Hotel.BLL
{
    /// <summary>
    /// 
    /// </summary>
    public class AdminService
    {
        #region Dependencies
        private IAdminRepository AdminRepository;
        #endregion

        /// <summary>
        /// Initialize all Dependencies
        /// </summary>
        public AdminService()
        {
            AdminRepository = new AdminRepository();
        }

        /// <summary>
        /// Check if the Logindata is correct.
        /// </summary>
        /// <param name="p_username">Username of the administrator.</param>
        /// <param name="p_password">Password of the administrator.</param>
        /// <returns>Adminobject if correct. NULL if incorrect.</returns>
        public Admin CheckLogin(string p_username, string p_password)
        {
            var admin = AdminRepository.GetByUsername(p_username);
            
            return Convert.ToBase64String(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(p_password))) != admin?.Password ? null : admin;
        }
    }
}
