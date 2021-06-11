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
            /* var person = new Person
             {
                 Name = "新井遥菜",
                 Birthday = new DateTime(1995, 11, 23),
                 PhoneNumber = "123-3456-7890",
             };

             var list = new List<int> { 10, 20, 30, 40, };
             var key = 50;
             var num = list.Contains(key) ? 1 : 0;
             Console.WriteLine(num);
           

            int count = 0;

            Console.WriteLine($"後置 : {count++}");
            //countの値は1
            Console.WriteLine($"前置 : {++count}");
         */

            var Session = new Dictionary<string, object>();
            Session["MyProduct"] = new  Product();

            var product = Session["MyProduct"] as Product;
            if (product == null)
            {
                Console.WriteLine("productが取得できなかった。");

             } else{
                Console.WriteLine("Productが取得できた。");
                    }
            }
            
        }
       
      /*  private static Product GetProductA()
        {
            Sale sale = new Sale();
           
            return sale?.Product;  //null条件演算子
        }
        
    }
        
        class Sale
    {
        public string ShopName { get; set; } = "abcd";
        public int Amount { get; set; } = 12340;
        public Product Product { get; set; }
      */
    }


