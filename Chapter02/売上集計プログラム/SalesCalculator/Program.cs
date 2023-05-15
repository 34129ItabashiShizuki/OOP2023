using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    class Program {
        static void Main(string[] args) {
            SalesCounter sales = new SalesCounter(ReadSales(@"data\sales.csv"));
            Dictionary<string, int> amountPerStore = sales.GetPerStoreSales();
            foreach (KeyValuePair<string, int> obj in amountPerStore) {
                Console.WriteLine("{0}{1:N0}", obj.Key, obj.Value);
            }
        }
        //売上データを読み込み、Saleオブジェクトのリストを返す
        static List<Sale> ReadSales(string filePath) {
            //売上データを格納する
            List<Sale> sales = new List<Sale>();

            //ファイルからすべてのデータを読み込む
            String[] lines = File.ReadAllLines(filePath);

            //すべての行から一行ずつ取り出す
            foreach(string line in lines) {
                //区切りで項目別に分ける
                String[] items = line.Split(',');
                //Saleインスタンス生成
                Sale sale = new Sale {
                    ShopName = items[0],
                    ProductCategory = items[0],
                    Amount = int.Parse(items[2])
                };
                //Saleインスタンスをコレクションに追加
                sales.Add(sale);
            }
            return sales;
        }
        
    }
}
