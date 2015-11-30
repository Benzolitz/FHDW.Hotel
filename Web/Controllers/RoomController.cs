using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FHDW.Hotel.BLL;
using FHDW.Hotel.DomainModel;

namespace FHDW.Hotel.Web.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class RoomController : BaseController
    {
        #region Dependencies
        private RoomService RoomService { get; set; }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        public RoomController()
        {
            RoomService = new RoomService();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage Get([FromUri(Name = "ID")] int p_id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, RoomService.GetById(p_id));
            }
            catch (Exception ex)
            {
                return base.HandleGeneralError(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage Get([FromUri(Name = "HotelId")] int p_hotelId, [FromUri(Name = "PageIndex")]int p_pageIndex, [FromUri(Name = "PageSize")]int p_pagesize)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, RoomService.GetCollectionByHotelId(p_hotelId, p_pageIndex, p_pagesize));
            }
            catch (Exception ex)
            {
                return base.HandleGeneralError(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage Get([FromUri(Name = "HotelId")] int p_id, [FromUri(Name = "Arrival")] DateTime p_arrival, [FromUri(Name = "Departure")] DateTime p_departure)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, RoomService.GetAvailableRooms(p_id, p_arrival, p_departure));
            }
            catch (Exception ex)
            {
                return base.HandleGeneralError(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage Post(Room p_room)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, RoomService.Save(p_room));
            }
            catch (Exception ex)
            {
                return base.HandleGeneralError(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage Put(Room p_room)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, RoomService.Save(p_room));
            }
            catch (Exception ex)
            {
                return base.HandleGeneralError(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage Delete(int p_id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, RoomService.DeleteById(p_id));
            }
            catch (Exception ex)
            {
                return base.HandleGeneralError(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage Delete(Room p_room)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, RoomService.Delete(p_room));
            }
            catch (Exception ex)
            {
                return base.HandleGeneralError(ex);
            }
        }
    }
}