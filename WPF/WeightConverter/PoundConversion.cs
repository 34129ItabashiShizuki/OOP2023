using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    public class PoundConversion : DistanceUnit{
        private static List<PoundConversion> units = new List<PoundConversion> {
            new PoundConversion {Name = "oz",Coefficient = 1,},
            new PoundConversion {Name = "lbs",Coefficient = 1 * 16,},
        };
        public static ICollection<PoundConversion> Units { get { return units; } }

        public double FromGramUnit(GramConversion unit, double value) {
            return (value * unit.Coefficient) / 28.3495231 / this.Coefficient;
        }
    }
}
