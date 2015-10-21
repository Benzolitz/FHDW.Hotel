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

        public HotelService()
        {
            HotelRepository = new HotelRepository();
        }

    }
}
