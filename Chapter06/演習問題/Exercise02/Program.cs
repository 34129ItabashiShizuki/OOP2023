﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var books = new List<Book> {
               new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
               new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
               new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
               new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
               new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
               new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
               new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };

            Exercise2_1(books);
            Console.WriteLine("-----");

            Exercise2_2(books);

            Console.WriteLine("-----");

            Exercise2_3(books);
            Console.WriteLine("-----");

            Exercise2_4(books);
            Console.WriteLine("-----");

            Exercise2_5(books);
            Console.WriteLine("-----");

            Exercise2_6(books);

            Console.WriteLine("-----");

            Exercise2_7(books);
        }

        private static void Exercise2_1(List<Book> books) {
            var code1= books.Where(n => n.Title=="ワンダフル・C#ライフ");
            foreach (var item in code1) {
                Console.WriteLine("価格:" + item.Price + "ページ数:" + item.Pages);
            }
        }

        private static void Exercise2_2(List<Book> books) {
            var code2 = books.Count(n => n.Title.Contains("C#"));
            Console.WriteLine(code2 + "冊");
        }

        private static void Exercise2_3(List<Book> books) {
            var code3 = books.Where(s => s.Title.Contains("C#")).Average(s => s.Pages);
            Console.WriteLine("平均ページ:" + code3);
        }

        private static void Exercise2_4(List<Book> books) {
            var code4 = books.First(s => s.Price >= 4000);
            Console.WriteLine(code4.Title);
        }

        private static void Exercise2_5(List<Book> books) {
            var code5 = books.Where(s => s.Price < 4000).Max(s => s.Pages);
            Console.WriteLine(code5);
        }

        private static void Exercise2_6(List<Book> books) {
            var code6 = books.OrderBy(s=> s.Pages >= 400);
            foreach (var item in code6) {
                Console.WriteLine(item.Title + item.Price);
            }
            
        }

        private static void Exercise2_7(List<Book> books) {
            
        }
    }
    class Book {
        public string Title { get; set; }
        public int Price { get; set; }
        public int Pages { get; set; }
    }
}
