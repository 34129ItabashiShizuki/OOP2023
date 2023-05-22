using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {

    public class ProductsCounter {
        private IEnumerable<Sale> _sales;

        //コンストラクタ
        public ProductsCounter(string filePath) {
            _sales = ReadSales(filePath);
        }
        //商品カテゴリ別売上を求める
        public IDictionary<string,int> GetPerStoreProduct() {
            var dict = new SortedDictionary<string, int>();
            foreach (var sale in _sales) {
                if (dict.ContainsKey(sale.ProductCategory))
                    dict[sale.ProductCategory] += sale.Amount; //店名が既に存在する(売上加算)
                else
                    dict[sale.ProductCategory] = sale.Amount;  //店名が存在しない(新規格納)
            }
            return dict;
        }
        //店舗別売上を求める
        public IDictionary<string, int> GetPerStoreSales() {
            var dict = new SortedDictionary<string, int>();
            foreach (var sale in _sales) {
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amount; //商品カテゴリーが既に存在する(売上加算)
                else
                    dict[sale.ShopName] = sale.Amount;  //商品カテゴリー名が存在しない(新規格納)
            }
            return dict;
        }
        //売上データを読み込み、Saleオブジェクトのリストを返す
        private IEnumerable<Sale> ReadSales(string filePath) {
            //売上データを格納する
            var sales = new List<Sale>();

            //ファイルからすべてのデータを読み込む
            var lines = File.ReadAllLines(filePath);

            //すべての行から一行ずつ取り出す
            foreach (var line in lines) {
                //区切りで項目別に分ける
                var items = line.Split(',');
                //Saleインスタンス生成
                var sale = new Sale {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                //Saleインスタンスをコレクションに追加
                sales.Add(sale);
            }
            return sales;
        }
    }
}
