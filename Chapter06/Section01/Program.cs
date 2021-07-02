using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = Books.GetBooks();

            Console.WriteLine("本の平均価格は" + books.Average(x => x.Price).ToString("#,0" + "円"));
            Console.WriteLine("本の総ページ数は" + books.Sum(x => x.Pages).ToString("#,0" + "ページ"));

            Console.WriteLine("本の最高値は" + books.Max(x => x.Price) + "円");
            Console.WriteLine("本の最低値は" + books.Min(x => x.Price) + "円");

            //５００円以上の本
            Console.WriteLine("500円以上の本は" + books.Count(x => x.Price >= 500) + "冊");




            /* 
              Console.WriteLine("物語がついている本は" + books.Count(c => c.Title.Contains("物語"))+ "冊");

              var bookDate = books.Where(x => x.Title.Contains("物語")).Take(2);
              foreach(var book in bookDate)
              {
                  Console.WriteLine(book.Title);

              }



              var s = books.OrderByDescending(c => c.Price).Take(3);


              foreach (var item in s)
              {
                  Console.WriteLine("本の最高値3つは" + item.Price + "円"+" "+item.Title);
              }
               */

           /* var titles = books.Select(x => x.Title);
            foreach (var item in titles)
            {
                Console.WriteLine(item);
            }
           */
            
            
            
            
           


        }
    }
}
