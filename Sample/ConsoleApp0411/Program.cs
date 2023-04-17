using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0411 {
    class Program {
        static void Main(string[] args) {

            //   string[] moneyString = { "一万円札" , "五千円札" , "二千円札" , "千円札" , 
            //                              "五百円玉" , "百円玉" , "十円玉" , "五円玉" , "一円玉" };
            //   int[] moneyInteger = { 10000,5000,2000,1000,500,100,50,10,5,1 };
            //金種枚数出力
            //       for (int i = 0; i < moneyString.length; i++)
            //       {
            //           Console.WriteLine(monetString[i] + "：{0}枚", change / moneyInteger[i]);
            //           astOut(change / moneyInteger[i])
            //           change % moneyInteger[i];
            //       }

            //金額入力:
            Console.WriteLine("**金額を入力**");
            Console.Write("金額:");
            int total = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //支払い入力
            Console.WriteLine("**支払いを入力**");
            Console.Write("支払い:");
            int pay = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //お釣り出力
            Console.WriteLine("**お釣りを出力**");
            int change = pay - total;
            Console.WriteLine("お釣り:" + change);
            Console.WriteLine();

            Console.WriteLine("一万円札:" + change / 10000);
            change = change % 10000;
            Console.WriteLine("五千円札:" + change / 5000);
            change = change % 5000;
            Console.WriteLine("二千円札:" + change / 2000);
            change = change % 2000;
            Console.WriteLine("  千円札:" + change / 1000);
            change = change % 1000;
            Console.WriteLine("五百円玉:" + change / 500);
            change = change % 500;
            Console.WriteLine("  百円玉:" + change / 100);
            change = change % 100;
            Console.WriteLine("  十円玉:" + change / 10);
            change = change % 10;
            Console.WriteLine("  五円玉:" + change / 5);
            change = change % 5;
            Console.WriteLine("  一円玉:" + change);
            change = change % 1;
            
            
        }

        //指定した個数の"*"を出力する
        private static void astOut(int count) {
            for (int i = 0; i < count; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); //改行
        }
    }
}
