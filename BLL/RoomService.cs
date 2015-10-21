using FHDW.Hotel.IRepository;
using FHDW.Hotel.Repository;

namespace FHDW.Hotel.BLL
{
    /// <summary>
    /// 
    /// </summary>
    public class RoomService
    {
        #region Dependencies
        private IRoomRepository RoomRepository { get; set; }
        #endregion

        public RoomService()
        {
            RoomRepository = new RoomRepository();
        }
    }
}
