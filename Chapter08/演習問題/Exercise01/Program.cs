using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            //var dateTime = new DateTime(2023, 6, 30, 11, 39, 32);
            var dateTime = DateTime.Now;
            DisplayDatePattern1(dateTime);
            DisplayDatePattern2(dateTime);
            DisplayDatePattern3(dateTime);
            DisplayDatePattern3_2(dateTime);
        }

        private static void DisplayDatePattern1(DateTime dateTime) {
            //2019/1/15 19;48
            var s1 = string.Format("{0:yyyy/M/d HH:mm}",dateTime);
            Console.WriteLine(s1);
        }

        private static void DisplayDatePattern2(DateTime dateTime) {
            //2019年01月15日 19時48分32秒
            var s2 = dateTime.ToString("yyyy年MM月dd日 HH時mm分ss秒");
            Console.WriteLine(s2);
        }

        private static void DisplayDatePattern3(DateTime dateTime) {
            //平成31年 1月15日(火曜日)
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var s3 = dateTime.ToString("ggyy年 M月d日",culture);
            var s4 = culture.DateTimeFormat.GetDayName(dateTime.DayOfWeek);
            Console.WriteLine("{0}({1})",s3,s4);
        }

        private static void DisplayDatePattern3_2(DateTime dateTime) {
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var s5 = dateTime.ToString("ggyy年 MM月dd日(dddd)", culture);
            var s6 = Regex.Replace(s5, @"0(\d)", " $1");
            Console.WriteLine(s6);
        }
    }
}
