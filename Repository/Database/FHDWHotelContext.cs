using System.Data.Common;
using System.Data.Entity;
using MySql.Data.Entity;

namespace FHDW.Hotel.Repository.Database
{
    /// <summary>
    /// 
    /// </summary>
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class FhdwHotelContext : DbContext
    {
        public DbSet<DomainModel.Address> Address { get; set; }
        public DbSet<DomainModel.Admin> Admin { get; set; }
        public DbSet<DomainModel.Booking> Booking { get; set; }
        public DbSet<DomainModel.Guest> Guest { get; set; }
        public DbSet<DomainModel.Hotel> Hotel { get; set; }
        public DbSet<DomainModel.Room> Room { get; set; }

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
