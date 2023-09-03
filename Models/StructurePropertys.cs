using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEnergyCalculator.Models
{
    public class StructurePropertys
    {
        public int StructurePropertyId { get; set; }
        public StructureCategory StructureCategory { get; set;}
        public string StructureName { get; set; }
        public string ImagePath { get; set; }
        public double HeatCapacity { get; set; }
        public double StructureThickness { get; set;}
    }
}
