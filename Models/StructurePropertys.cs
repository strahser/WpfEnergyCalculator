using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEnergyCalculator.Models
{
    [Table("StructurePropertys")]
    public class StructurePropertys
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StructurePropertyId { get; set; }
        public StructureCategory StructureCategory { get; set;}
        public string StructureName { get; set; }
        public string ImagePath { get; set; }
        public double HeatCapacity { get; set; }
        public double StructureThickness { get; set;}
    }
}
