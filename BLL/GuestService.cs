using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository;

namespace FHDW.Hotel.BLL
{
    /// <summary>
    /// Handle all Requests for the Guest.
    /// </summary>
    /// <creator>Lucas Engel</creator>
    public class GuestService
    {
        #region Dependencies
        private IGuestRepository GuestRepository { get; set; }
        #endregion

        /// <summary>      
        /// Initialize the GuestService.
        /// </summary>
        public GuestService()
        {
            GuestRepository = new GuestRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_email"></param>
        /// <param name="p_password"></param>
        /// <returns></returns>
        public Guest CheckLogin(string p_email, string p_password)
        {
            return GuestRepository.GetByEmail(p_email);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_guest"></param>
        /// <returns></returns>
        public Guest SaveGuest(Guest p_guest)
        {
            if (p_guest == null) return null;

            return p_guest.ID == 0 ? GuestRepository.Insert(p_guest) : GuestRepository.Update(p_guest);
        }
    }
}
