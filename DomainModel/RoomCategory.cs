using System.ComponentModel.DataAnnotations.Schema;

namespace FHDW.Hotel.DomainModel
{
    /// <summary>
    /// Roomcategorymodel
    /// </summary>
    [Table("RoomCategory")]
    public class RoomCategory
    {
        /// <summary>
        /// ID of the category
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Categoryname
        /// </summary>
        public string Category { get; set; }
    }
}
