using System;
using System.Security.Cryptography;
using System.Text;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository.Repositories;

namespace FHDW.Hotel.BLL
{
    /// <summary>
    /// Handles all logical decisions for the Guestobject.
    /// </summary>
    /// <creator>Lucas Engel</creator>
    public class GuestService
    {
        #region Dependencies
        private readonly IGuestRepository _guestRepository;
        #endregion

        /// <summary>      
        /// Initialize the Service.
        /// </summary>
        public GuestService()
        {
            _guestRepository = new GuestRepository();
        }

        /// <summary>
        /// Check if the Logindata is correct.
        /// </summary>
        /// <param name="p_email">Emailaddress</param>
        /// <param name="p_password">Password</param>
        /// <returns>Guestobject, or NULL</returns>
        public Guest CheckLogin(string p_email, string p_password)
        {
            var guest = _guestRepository.GetByEmail(p_email);

            if (guest == null) return null;
            return Convert.ToBase64String(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(p_password))) == guest.Password ? guest : null;
        }

        /// <summary>
        /// Add, or Update a Guest.
        /// </summary>
        /// <param name="p_guest">Guestobject</param>
        /// <returns>Updated, or added Guest.</returns>
        public Guest SaveGuest(Guest p_guest)
        {
            if (p_guest == null) return null;

            p_guest.Password = Convert.ToBase64String(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(p_guest.Password)));
            return p_guest.ID == 0 ? _guestRepository.Insert(p_guest) : _guestRepository.Update(p_guest);
        }
    }
}
