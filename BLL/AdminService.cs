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
        
        public AdminService()
        {
            AdminRepository = new AdminRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_username"></param>
        /// <returns></returns>
        public Admin GetByUsername(string p_username)
        {
            return AdminRepository.GetByUsername(p_username);
        }
    }
}
