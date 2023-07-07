using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var datetime = DateTime.Now;
            //Console.WriteLine("{0}:yy/MM/dd(ddd)",datetime);
            var s1 = datetime.ToString("d");
            foreach (var dayofweek in Enum.GetValues(typeof(DayOfWeek))) {
                Console.WriteLine("{0}次週の{1}:{2}",s1,dayofweek,NextWeek(datetime,(DayOfWeek)dayofweek));
                
            }
            Console.WriteLine();
        }
        public static DateTime NextWeek(DateTime date,DayOfWeek dayOfWeek) {
            int days = dayOfWeek - date.DayOfWeek;
            if (days <= 0)
                days += 7;
            return date.AddDays(days);
        }
    }
}
