using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {

            #region 7.1
            //var flowerDict = new Dictionary<string, int>() {
            //    ["sunflower"] = 400,
            //    ["pansy"] = 300,
            //    ["tulip"] = 350,
            //    ["rose"] = 500,
            //    ["dahlia"] = 450,
            //};

            //flowerDict["morning glory"] = 250;

            //Console.WriteLine("ひまわりの価格は{0}円です。",flowerDict["sunflower"]);
            //Console.WriteLine("チューリップの価格は{0}円です。",flowerDict["tulip"]);
            //Console.WriteLine("あさがおの価格は{0}円です。",flowerDict["morning glory"]);
            #endregion
            var a = new Dictionary<string, string>();

            string name, city;

            Console.WriteLine("県庁所在地の登録");


            while (true) {
                Console.Write("県名:");
                name = Console.ReadLine();
                if (name == "999") break;
                Console.Write("所在地:");
                city = Console.ReadLine();
                if (a.ContainsKey(name)) {
                    Console.WriteLine("既に県名が登録されています。");
                    Console.WriteLine("上書きしますか？(y/n)");
                    if (Console.ReadLine() != "y") {
                        continue;
                    }
                }
                a[name] = city;
            }
            Console.WriteLine();
            Console.WriteLine("1:一覧表示,2:県名指定");
            Console.Write(">");
            var selected = Console.ReadLine();

            if (selected == "1") {
                //一覧表示
                foreach (var item in a) {
                    Console.WriteLine("{0}({1})", item.Key, item.Value);
                }
            }
            else {
                //県名指定表示
                Console.Write("県名:");
                var c = Console.ReadLine();
                Console.WriteLine("{0}です", a[c]);
            }
        }
    }
    class CityInfo {
        string City { get; set; }       //都市
        string Population { get; set; } //人口
    }
}
