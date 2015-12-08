using System.Data.Entity;
using FHDW.Hotel.DomainModel;
using MySql.Data.Entity;

namespace FHDW.Hotel.Repository.Database
{
    /// <summary>
    /// 
    /// </summary>
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class FhdwHotelContext : DbContext
    {
        public DbSet<Address> Address { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<Guest> Guest { get; set; }
        public DbSet<DomainModel.Hotel> Hotel { get; set; }
        public DbSet<Room> Room { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public FhdwHotelContext() : base("name=fhdwhotel")
        {
            
        }
    }
}
