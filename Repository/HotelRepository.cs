using System.Collections.Generic;
using FHDW.Hotel.IRepository;

namespace FHDW.Hotel.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public class HotelRepository : IHotelRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ICollection<DomainModel.Hotel> Get()
        {
            // var query = base.ExecuteQuery("SELECT * FROM hotel");
            // MessageBox.Show(query.ToString());
            return new List<DomainModel.Hotel>();
        }
    }
}
