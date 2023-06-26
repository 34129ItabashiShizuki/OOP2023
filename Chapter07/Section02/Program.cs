using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02 {
    class Program {
        static void Main(string[] args) {
            var prefDict = new Dictionary<string,List<CityInfo>>();

            string name;
            Console.WriteLine("都市の登録");


            while (true) {
                var cityinfo = new CityInfo();
                
                Console.Write("県名:");
                name = Console.ReadLine();
                if (name == "999") break;

                Console.Write("市町村名:");
                cityinfo.City = Console.ReadLine();
                Console.Write("人口:");
                cityinfo.Population = int.Parse(Console.ReadLine());

                if (prefDict.ContainsKey(name)) {
                    prefDict[name].Add(cityinfo);
                    //Console.WriteLine("既に県名が登録されています。");
                    //Console.WriteLine("追加しますか？(y/n)");
                    //if (Console.ReadLine() != "y") {
                    //    continue;
                    //}
                }
                else {
                    prefDict[name] = new List<CityInfo> { cityinfo };
                }
                
                //登録処理
                //a[name] = new CityInfo() {
                //    City = cityinfo,
                //    Population = population
                //};
                //prefDict[name] = cityinfo;
            }
            Console.WriteLine();
            Console.WriteLine("1:一覧表示,2:県名指定");
            Console.Write(">");
            var selected = Console.ReadLine();

            if (selected == "1") {
                //一覧表示
                foreach (var item1 in prefDict) {
                    foreach (var item2 in item1.Value) {
                        Console.WriteLine("{0}[{1}(人口:{2}人)]", item1.Key, item2.City, item2.Population);
                    }
                }
            }
            else {
                //県名指定表示
                Console.Write("県名:");
                var c = Console.ReadLine();
                foreach (var item in prefDict[c]) {
                    Console.WriteLine(item.City + "人口:" + item.Population);
                }
            }
        }
    }
    class CityInfo {
        public string City { get; set; }       //都市
        public int Population { get; set; } //人口
    }
}
