using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var sales = new ProductsCounter(@"data\sales.csv");
            Console.WriteLine("**売上集計**");
            Console.WriteLine("1:店舗別売上");
            Console.WriteLine("2:商品カテゴリー別売上");
            Console.Write(">");
            int select = int.Parse(Console.ReadLine());
            if (select == 1) {
                var amountPerProducts = sales.GetPerStoreProduct();
                foreach (var obj in amountPerProducts) {
                    Console.WriteLine("{0}{1:N0}", obj.Key, obj.Value);
                }
            }
            else if (select == 2){
                var amountPerSales = sales.GetPerStoreSales();
                foreach (var obj in amountPerSales) {
                    Console.WriteLine("{0}{1:N0}", obj.Key, obj.Value);
                }
            }
            else {
                Console.WriteLine("1か２を入力してください。");
            }
        }
    }
}
