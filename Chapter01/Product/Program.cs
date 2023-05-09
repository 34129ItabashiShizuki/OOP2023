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

            #region 0508演習1
            //DateTime date = new DateTime(2023, 5, 8);
            ////DateTime date = DateTime.Today;

            ////今日の日付
            //Console.WriteLine(date.Year + "年" + date.Month + "月" + date.Day + "日");

            ////10日後を求める
            //Console.WriteLine("10日後は" + date.Adddays(10).Year+ "年"+ date.Adddays(10).Month+ "月"+ date.Adddays(10).Day + "日です。");

            ////10日前を求める
            //Console.WriteLine("10日前は" + date.Adddays(10).Year + "年"+ date.Adddays(-10).Month + "月" + date.Adddays(-10).Day + "日です。");
            #endregion
            #region 0509演習2
            Console.WriteLine("誕生日を入力");

            //西暦の入力
            Console.Write("西暦:");
            int Ad = int.Parse(Console.ReadLine());
            
            //月の入力
            Console.Write("月:");
            int Month = int.Parse(Console.ReadLine());

            //日の入力
            Console.Write("日:");
            int Day = int.Parse(Console.ReadLine());

            DateTime birth = new DateTime(Ad, Month, Day);
            DateTime today = DateTime.Today;

            TimeSpan ts = today - birth;

            Console.WriteLine("あなたは生まれてから今日まで{0}日目です", ts.Days);
            #endregion

            #region 0509演習３
            Console.Write("あなたは{0}に生まれました",birth.ToString("dddd"));
            #endregion
        }
    }
}
