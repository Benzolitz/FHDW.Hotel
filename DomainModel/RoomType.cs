using System.ComponentModel.DataAnnotations.Schema;

namespace FHDW.Hotel.DomainModel
{
    /// <summary>
    /// Roomtypemodel
    /// </summary>
    [Table("RoomType")]
    public class RoomType
    {
        /// <summary>
        /// ID of the Type
        /// </summary>
        public int ID { get; set; }
        
        /// <summary>
        /// Typename
        /// </summary>
        public string Type { get; set; }
    }
}
