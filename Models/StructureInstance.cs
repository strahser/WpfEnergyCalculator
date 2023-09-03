using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEnergyCalculator.Models
{
    public class StructureInstance
    {
        public int  StructureInstanceID { get; set; }
        public string StructureInstanceOrientation { get; set; }
        public double StructureInstanceArea { get; set; }
        public StructurePropertys StructureProperty { get; set; }

    }

}
