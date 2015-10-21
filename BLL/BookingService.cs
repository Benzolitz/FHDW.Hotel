using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository;

namespace FHDW.Hotel.BLL
{
    /// <summary>
    /// 
    /// </summary>
    public class BookingService
    {
        #region Dependencies
        private IBookingRepository BookingRepository { get; set; }
        #endregion

        public BookingService()
        {
            BookingRepository = new BookingRepository();
        }
    }
}
