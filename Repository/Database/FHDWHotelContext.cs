using System.Data.Common;
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
        public FhdwHotelContext() : base("fhdwhotel")
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_existingConnection"></param>
        /// <param name="p_contextOwnsConnection"></param>
        public FhdwHotelContext(DbConnection p_existingConnection, bool p_contextOwnsConnection) : base(p_existingConnection, p_contextOwnsConnection)
        {

        }
    }
}
