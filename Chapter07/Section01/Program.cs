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
            var a = new Dictionary<string, CityInfo>();

            string name;
            Console.WriteLine("県庁所在地の登録");


            while (true) {
                var cityinfo = new CityInfo();

                Console.Write("県名:");
                name = Console.ReadLine();
                if (name == "999") break;
                Console.Write("所在地:");
                cityinfo.City = Console.ReadLine();
                Console.Write("人口:");
                cityinfo.Population = int.Parse(Console.ReadLine());
                if (a.ContainsKey(name)) {
                    Console.WriteLine("既に県名が登録されています。");
                    Console.WriteLine("上書きしますか？(y/n)");
                    if (Console.ReadLine() != "y") {
                        continue;
                    }
                }
                //登録処理
                //a[name] = new CityInfo() {
                //    City = cityinfo,
                //    Population = population
                //};
                a[name] = cityinfo;
            }
            Console.WriteLine();
            Console.WriteLine("1:一覧表示,2:県名指定");
            Console.Write(">");
            var selected = Console.ReadLine();

            if (selected == "1") {
                //一覧表示
                
                foreach (var item in a.OrderByDescending(x => x.Value.Population)) {
                    Console.WriteLine("{0}[{1}(人口:{2}人)]", item.Key, item.Value.City,item.Value.Population);
                }
            }
            else {
                //県名指定表示
                Console.Write("県名:");
                var c = Console.ReadLine();
                Console.WriteLine(a[c].City + "人口:" +a[c].Population);
            }
        }
    }
    class CityInfo {
        public string City { get; set; }       //都市
        public int Population { get; set; } //人口
    }
}
