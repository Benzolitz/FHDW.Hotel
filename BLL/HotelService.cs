using System.Collections.Generic;
using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository;

namespace FHDW.Hotel.BLL
{
    /// <summary>
    /// 
    /// </summary>
    public class HotelService
    {
        #region Dependencies
        private IHotelRepository HotelRepository { get; set; }
        #endregion

        /// <summary>
        /// Initialize all Dependencies.
        /// </summary>
        public HotelService()
        {
            HotelRepository = new HotelRepository();
        }

        /// <summary>
        /// Get a Collection of all Hotels.
        /// </summary>
        /// <returns>Hotel-Collection</returns>
        public ICollection<DomainModel.Hotel> GetCollection()
        {
            return HotelRepository.GetCollection();
        }
    }
}
