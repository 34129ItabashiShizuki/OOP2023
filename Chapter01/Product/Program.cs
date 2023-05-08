using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {

    class Program {
        static void Main(string[] args) {
            #region P26のサンプルプログラム
            //インスタンス生成
            //Product karinto = new Product(123, "かりんとう", 180);
            //Product daifuku = new Product(1235, "大福もち", 160);
            //Console.WriteLine("かりんとう税込価格:" + karinto.GetPriceIncloudingTax());
            //Console.WriteLine("大福もち税込価格:" + daifuku.GetPriceIncloudingTax());
            #endregion

            DateTime date = new DateTime(2023, 5, 8);
            //DateTime date = DateTime.Today;

            //今日の日付
            Console.WriteLine(date.Year + "年" + date.Month + "月" + date.Day + "日");

            //10日後を求める
            DateTime daysAfter10 = date.AddDays(10);
            Console.WriteLine("10日後は" + daysAfter10.Month + "月" + daysAfter10.Day + "日です。");

            //10日前を求める
            DateTime daysbefore10 = date.AddDays(-10);
            Console.WriteLine("10日前は" + daysbefore10.Month + "月" + daysbefore10.Day + "日です。");
        }
    }
}
