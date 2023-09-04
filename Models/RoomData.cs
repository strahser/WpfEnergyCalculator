using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfEnergyCalculator.Models
{
    [Table("RoomData")]
    public class RoomData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomDataID { get; set; } 
        public string RoomType { get; set; }
        public string RoomProperty { get; set; }
        public Double RoomArea { get; set; }
        public Double RoomHeight { get; set; }

    }
}
