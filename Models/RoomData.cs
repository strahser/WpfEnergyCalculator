using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEnergyCalculator.Models
{
    public class RoomData
    {
        public int RoomDataID { get; set; } 
        public string RoomType { get; set; }
        public string RoomProperty { get; set; }
        public Double RoomArea { get; set; }
        public Double RoomHeight { get; set; }

    }
}
