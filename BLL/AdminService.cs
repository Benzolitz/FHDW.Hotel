using System;
using System.Security.Cryptography;
using System.Text;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository.Repositories;

namespace FHDW.Hotel.BLL
{
    /// <summary>
    /// Handles all logical decisions for the Adminobject.
    /// </summary>
    /// <author>Lucas Engel</author>
    public class AdminService
    {
        #region Dependencies
        private readonly IAdminRepository _adminRepository;
        #endregion

        /// <summary>
        /// Initialize the AdminService.
        /// </summary>
        public AdminService()
        {
            _adminRepository = new AdminRepository();
        }

        /// <summary>
        /// Check if the Logindata is correct.
        /// </summary>
        /// <param name="p_username">Username of the administrator.</param>
        /// <param name="p_password">Password of the administrator.</param>
        /// <returns>Adminobject if correct. NULL if incorrect.</returns>
        public Admin CheckLogin(string p_username, string p_password)
        {
            var admin = _adminRepository.GetByUsername(p_username);

            if (admin == null) return null;
            return Convert.ToBase64String(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(p_password))) == admin.Password ? admin : null;
        }
    }
}
