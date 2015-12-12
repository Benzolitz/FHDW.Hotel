using System.Collections.Generic;
using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository.Repositories;

namespace FHDW.Hotel.BLL
{
    /// <summary>
    /// Handles all logical decisions for the Hotelobject.
    /// </summary>
    /// <creator>Lucas Engel</creator>
    public class HotelService
    {
        #region Dependencies
        private readonly IHotelRepository _hotelRepository;
        #endregion

        /// <summary>
        /// Initialize the Service.
        /// </summary>
        public HotelService()
        {
            _hotelRepository = new HotelRepository();
        }

        /// <summary>
        /// Get a Collection of all Hotels.
        /// </summary>
        /// <returns>Filled or Empty Collection</returns>
        public ICollection<DomainModel.Hotel> GetCollection()
        {
            return _hotelRepository.GetCollection();
        }

        /// <summary>
        /// Get a specific Hotel by ID
        /// </summary>
        /// <param name="p_id">ID of the Hotel</param>
        /// <returns>Filled Hotelobject, or NULL</returns>
        public DomainModel.Hotel GetById(int p_id)
        {
            return _hotelRepository.GetById(p_id);
        }
    }
}
