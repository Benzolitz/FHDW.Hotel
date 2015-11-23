using System.Collections.Generic;
using FHDW.Hotel.DomainModel;
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ICollection<DomainModel.Hotel> GetCollection()
        {
            // TODO: Remove Testdata!

            var hotel1 = new DomainModel.Hotel
            {
                Name = "Hotel1",
                ID = 1,
                Address = new Address
                {
                    ID = 1,
                    City = "Hier",
                    PostalCode = "456789",
                    Street = "asd awe  asd 12"
                }
            };

            var hotel2 = new DomainModel.Hotel
            {
                Name = "Hotel2",
                ID = 2,
                Address = new Address
                {
                    ID = 1,
                    City = "Hier",
                    PostalCode = "456789",
                    Street = "asd awe  asd 12"
                }
            };

            var hotel3 = new DomainModel.Hotel
            {
                Name = "Hotel3",
                ID = 3,
                Address = new Address
                {
                    ID = 1,
                    City = "Hier",
                    PostalCode = "456789",
                    Street = "asd awe  asd 12"
                }
            };

            return new List<DomainModel.Hotel> { hotel1, hotel2, hotel3 };
            // return HotelRepository.GetCollection();
        }
    }
}
