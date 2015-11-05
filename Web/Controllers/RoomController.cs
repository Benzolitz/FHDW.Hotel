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
        public HttpResponseMessage Get()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new[] { "Room1", "Room2" });
            }
            catch (Exception ex)
            {
                return base.HandleError(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage Get([FromUri(Name = "ID")] int p_id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new[] { "Room1", "Room2" });
            }
            catch (Exception ex)
            {
                return base.HandleError(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage Get([FromUri(Name = "Type")] Enums.RoomType p_type)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new[] { "Room1", "Room2" });
            }
            catch (Exception ex)
            {
                return base.HandleError(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage Get([FromUri(Name = "Category")] Enums.RoomCategory p_category)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new[] { "Room1", "Room2" });
            }
            catch (Exception ex)
            {
                return base.HandleError(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage Get([FromUri(Name = "Arrival")] DateTime p_arrival, [FromUri(Name = "Departure")] DateTime p_departure)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new[] { "Room1", "Room2" });
            }
            catch (Exception ex)
            {
                return base.HandleError(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage Get([FromUri(Name = "HotelID")] int p_hotelId, [FromUri(Name = "PageIndex")] int p_pageIndex, [FromUri(Name = "PageSize")] int p_pageSize, [FromUri(Name = "OrderBy")] string p_orderBy, [FromUri(Name = "SortOrder")] Enums.SortOrder p_sortOrder)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new[] { "Room1", "Room2" });
            }
            catch (Exception ex)
            {
                return base.HandleError(ex);
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
                return Request.CreateResponse(HttpStatusCode.OK, new[] { "Room1", "Room2" });
            }
            catch (Exception ex)
            {
                return base.HandleError(ex);
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
                return Request.CreateResponse(HttpStatusCode.OK, new[] { "Room1", "Room2" });
            }
            catch (Exception ex)
            {
                return base.HandleError(ex);
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
                return Request.CreateResponse(HttpStatusCode.OK, new[] { "Room1", "Room2" });
            }
            catch (Exception ex)
            {
                return base.HandleError(ex);
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
                return Request.CreateResponse(HttpStatusCode.OK, new[] { "Room1", "Room2" });
            }
            catch (Exception ex)
            {
                return base.HandleError(ex);
            }
        }
    }
}