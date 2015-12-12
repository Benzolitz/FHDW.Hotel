using System.Data.Entity;
using FHDW.Hotel.DomainModel;
using MySql.Data.Entity;

namespace FHDW.Hotel.Repository.Database
{
    /// <summary>
    /// Schema for the database.
    /// </summary>
    /// <author>Lucas Engel</author>
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class FhdwHotelContext : DbContext
    {
        /// <summary>
        /// Addresstable.
        /// </summary>
        public DbSet<Address> Address { get; set; }

        /// <summary>
        /// Admintable.
        /// </summary>
        public DbSet<Admin> Admin { get; set; }

        /// <summary>
        /// Bookingtable
        /// </summary>
        public DbSet<Booking> Booking { get; set; }

        /// <summary>
        /// Guesttable.
        /// </summary>
        public DbSet<Guest> Guest { get; set; }

        /// <summary>
        /// Hoteltable.
        /// </summary>
        public DbSet<DomainModel.Hotel> Hotel { get; set; }

        /// <summary>
        /// Roomtable.
        /// </summary>
        public DbSet<Room> Room { get; set; }

        /// <summary>
        /// Roomtypetable
        /// </summary>
        public DbSet<RoomType> RoomType { get; set; }

        /// <summary>
        /// Roomcategorytable
        /// </summary>
        public DbSet<RoomCategory> RoomCategory { get; set; }

        /// <summary>
        /// Initialize the Schema and use the name "fhdwhotel".
        /// </summary>
        public FhdwHotelContext() : base("name=fhdwhotel")
        {
            
        }
    }
}
