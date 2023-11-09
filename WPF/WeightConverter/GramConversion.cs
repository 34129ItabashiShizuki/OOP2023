using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    public class GramConversion : DistanceUnit{
        private static List<GramConversion> units = new List<GramConversion> {
            new GramConversion {Name = "g",Coefficient = 1,},
            new GramConversion {Name = "kg",Coefficient = 1 * 1000,},
        };
        public static ICollection<GramConversion> Units { get { return units; } }

        public double FromPoundUnit(PoundConversion unit, double value) {
            return (value * unit.Coefficient) * 28.3495231 / this.Coefficient;
        }
    }
}
