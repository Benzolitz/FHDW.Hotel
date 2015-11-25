using System.Collections.Generic;
using FHDW.Hotel.DomainModel;
using FHDW.Hotel.IRepository;

namespace FHDW.Hotel.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public class GuestRepository : IGuestRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ICollection<Guest> GetCollection()
        {
            return new List<Guest>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_id"></param>
        /// <returns></returns>
        public Guest GetById(int p_id)
        {
            return new Guest();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_email"></param>
        /// <returns></returns>
        public Guest GetByEmail(string p_email)
        {
            return new Guest();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_guest"></param>
        /// <returns></returns>
        public Guest Insert(Guest p_guest)
        {
            return new Guest();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_guest"></param>
        /// <returns></returns>
        public Guest Update(Guest p_guest)
        {
            return new Guest();
        }
    }
}