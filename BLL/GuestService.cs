using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository;

namespace FHDW.Hotel.BLL
{
    /// <summary>
    /// 
    /// </summary>
    public class GuestService
    {
        #region Dependencies
        private IGuestRepository GuestRepository { get; set; }
        #endregion

        public GuestService()
        {
            GuestRepository = new GuestRepository();
        }
    }
}
