using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FHDW.Hotel.DomainModel
{
    /// <summary>
    /// 
    /// </summary>
    [Table("Hotel")]
    public class Hotel
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Address Address { get; set; }
        
        public ICollection<Room> Rooms { get; set; }
    }
}
