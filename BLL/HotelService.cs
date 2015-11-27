using System.Collections.Generic;
using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository;

namespace FHDW.Hotel.BLL
{
    /// <summary>
    /// Handle all Requests for the Hotel.
    /// </summary>
    /// <creator>Lucas Engel</creator>
    public class HotelService
    {
        #region Dependencies
        private IHotelRepository HotelRepository { get; set; }
        #endregion

        /// <summary>
        /// Initialize the HotelService.
        /// </summary>
        public HotelService()
        {
            HotelRepository = new HotelRepository();
        }

        /// <summary>
        /// GetById a Collection of all Hotels.
        /// </summary>
        /// <returns>Hotel-Collection</returns>
        public ICollection<DomainModel.Hotel> GetCollection()
        {
            return HotelRepository.GetCollection();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public DomainModel.Hotel GetById(int p_id)
        {
            return HotelRepository.GetById(p_id);
        }
    }
}
