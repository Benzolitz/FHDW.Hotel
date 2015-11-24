using System;
using System.Collections.Generic;
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
                ICollection<Room> rooms = RoomService.GetCollection();

                return Request.CreateResponse(HttpStatusCode.OK, rooms);
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
        public HttpResponseMessage Get([FromUri(Name = "Hotel")] DomainModel.Hotel p_hotel)
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