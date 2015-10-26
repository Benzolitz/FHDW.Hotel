using System.Collections.Generic;
using System.Windows.Forms;
using FHDW.Hotel.IRepository;

namespace FHDW.Hotel.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public class HotelRepository : BaseRepository, IHotelRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ICollection<DomainModel.Hotel> Get()
        {
            var query = base.ExecuteQuery<DomainModel.Hotel>("SELECT * FROM hotel");
            return new List<DomainModel.Hotel>();
        }
    }
}
