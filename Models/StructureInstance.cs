using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEnergyCalculator.Models
{
    [Table("StructureInstance")]
    public class StructureInstance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int  StructureInstanceID { get; set; }
        public string StructureInstanceOrientation { get; set; }
        public double StructureInstanceArea { get; set; }
        public StructurePropertys StructureProperty { get; set; }

    }

}
