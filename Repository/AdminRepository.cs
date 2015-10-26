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
        /// 
        /// </summary>
        /// <param name="p_username"></param>
        /// <returns></returns>
        public Admin GetByUsername(string p_username)
        {
            return new Admin();
        }
    }
}
