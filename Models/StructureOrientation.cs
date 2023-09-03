using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfEnergyCalculator.Models
{
    public class StructureOrientation
    {

        public static readonly string South = "Ю";

        public static readonly string Noth = "С";

        public static readonly string West = "З";

        public static readonly string East = "В";

        public static readonly string Horizontal = "Горизонтальная";
        public static List<string> GetPossibleOrientationTypes()
        {
            List<string> res = new List<string>()
            {
                Noth,
                South,
                West,
                East,
                Horizontal
            };
            return res;
        }


    }
}
