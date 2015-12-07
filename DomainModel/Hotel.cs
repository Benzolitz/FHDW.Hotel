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
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual Address Address { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}
