using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FHDW.Hotel.DomainModel
{
    /// <summary>
    /// 
    /// </summary>
    [Table("Room")]
    public class Room
    {
        public int ID { get; set; }
        public string RoomNumber { get; set; }
        public int PersonCount { get; set; }
        public float Price { get; set; }

        [Column("Category")]
        [Required]
        public string CategoryMapping
        {
            get { return Category.ToString(); }
            set { Category = EnumExtensions.ParseEnum<Enums.RoomCategory>(value); }
        }

        [Column("Type")]
        [Required]
        public string TypeMapping
        {
            get { return Type.ToString(); }
            set { Type = EnumExtensions.ParseEnum<Enums.RoomType>(value); }
        }
        public Hotel Hotel { get; set; }
        public ICollection<Booking> Bookings { get; set; }


        /// <summary>
        /// Don't map enums, because they will be saved as integer. We want strings.
        /// </summary>
        [NotMapped]
        public Enums.RoomCategory Category { get; set; }

        [NotMapped]
        public Enums.RoomType Type { get; set; }
    }
}
