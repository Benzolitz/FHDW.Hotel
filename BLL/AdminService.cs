﻿using System;
using System.Security.Cryptography;
using System.Text;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository;
using FHDW.Hotel.Repository.Repositories;

namespace FHDW.Hotel.BLL
{
    /// <summary>
    /// Handle all Requests for the Admin.
    /// </summary>
    /// <creator>Lucas Engel</creator>
    public class AdminService
    {
        #region Dependencies
        private readonly IAdminRepository AdminRepository;
        #endregion

        /// <summary>
        /// Initialize the AdminService.
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

            if (admin == null) return null;

            return Convert.ToBase64String(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(p_password))) != admin.Password ? null : admin;
        }
    }
}
