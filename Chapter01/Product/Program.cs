using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {

    class Program {
        static void Main(string[] args) {
            //インスタンス生成
            Product karinto = new Product(123, "かりんとう", 180);
            Product daifuku = new Product(1235, "大福もち", 160);
            Console.WriteLine("かりんとう税込価格:" + karinto.GetPriceIncloudingTax());
            Console.WriteLine("大福もち税込価格:" + daifuku.GetPriceIncloudingTax());
        }
    }
}
