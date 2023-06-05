using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);

        }

        private static void Exercise3_1(string text) {
            var count = text.Count(t => t == ' ');
            Console.WriteLine("空白数:" + count);
        }

        private static void Exercise3_2(string text) {
            Console.WriteLine("変更前:"+ text);
            var replacement = text.Replace("big", "small");
            Console.WriteLine("変更後:" + replacement);
        }

        private static void Exercise3_3(string text) {
            var count = text.Split().Count();
            Console.WriteLine("単語数:" + count);
        }

        private static void Exercise3_4(string text) {
            var count = text.Split(' ').Where(t => t.Length <= 4);
            foreach (var item in count) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise3_5(string text) {
            var word = text.Split(' ').ToList();
            var sb = new StringBuilder();
            foreach (var item in word) {
                sb.Append(item + ' ');
            }
            var t1  = sb.ToString();
            Console.WriteLine(t1);
        }
    }
}
