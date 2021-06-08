using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section1
{
    class Program
    {
        private static object console;

        static void Main(string[] args)
        {
            /*     var names = new List<string> {
              "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
                 };

                 IEnumerable<string> query = names.Where(s => s.Length <= 5).
                                                             Select(s=>s.ToLower());

                 foreach (string s in query)
                 {
                     Console.WriteLine(s);
              }
             */
            /* string[] names = {
             "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra"  };
         var query = names.Where(s => s.Length <= 5).ToList();

             query.ForEach(Console.WriteLine);

             foreach (var item in query)
                 Console.WriteLine(item);
             Console.WriteLine("------");

             names[0] = "Osaka";

             foreach (var item in query)
             Console.WriteLine(item);
         */
            /*
              var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 
                                                          76, 91, 31, 17, 48 };

              // 3.1.1
              Exercise1_1(numbers);
              Console.WriteLine("-----");

              // 3.1.2
              Exercise1_2(numbers);
              Console.WriteLine("-----");

              // 3.1.3
              Exercise1_3(numbers);
              Console.WriteLine("-----");

              // 3.1.4
              Exercise1_4(numbers);
          }

          private static void Exercise1_4(List<int> numbers)
          {
              //var nums = numbers.Select(s => s * 2);

              List<int> list = numbers.Select(n => n * 2).ToList();
                  foreach(var num in list)
              {
                  Console.WriteLine(num);
              }

              //foreach (var s in numbers.Select(s => s * 2))
                //  Console.WriteLine("{0}", s);


          }

          private static void Exercise1_3(List<int> numbers)
          {
              //var query = numbers.Where(s => 50 <= s);
              foreach (var s in numbers.Where(n=> n >= 50))
              {
                  Console.WriteLine(s);
              }

          }

          private static void Exercise1_2(List<int> numbers)
          {
              numbers.ForEach(n =>  Console.WriteLine(n / 2.0));
          }

          private static void Exercise1_1(List<int> numbers)
          {
              var exists = numbers.Exists(s => s % 8 == 0 || s % 9 == 0);
              if (exists)
                  Console.WriteLine("存在します");
              else
                  Console.WriteLine("存在しません");
          }
       */
            var names = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris"
                                                       , "Berlin", "Canberra", "Hong Kong", };
            // 3.2.1
            Exercise2_1(names);
            Console.WriteLine();

            // 3.2.2
            Exercise2_2(names);
            Console.WriteLine();

            // 3.2.3
            Exercise2_3(names);
            Console.WriteLine();

            // 3.2.4
            Exercise2_4(names);

            //できた人

            Exercise2_5(names);

        }

        private static void Exercise2_5(List<string> names)
        {
            int count = 0;
           foreach(var name in names)
            {
                count += name.Count(c => char.IsLower(c));

            }
            Console.WriteLine(count);
        }

        private static void Exercise2_1(List<string> names)
        {
            Console.WriteLine("都市名入力");
            var line = Console.ReadLine();
            var index = names.FindIndex(s => s == line);
            Console.WriteLine(index);
            
            
            
        }

        private static void Exercise2_2(List<string> names)
        {
            var count = names.Count(s => s.Contains('o'));
                Console.WriteLine(count);
        }

        private static void Exercise2_3(List<string> names)
        {
            var query = names.Where(s => s.Contains('o')).ToArray();
           foreach(var n in query)
            Console.WriteLine(n);
        }

        private static void Exercise2_4(List<string> names)
        {

            var query = names.Where(s => s.StartsWith("B")).Select(s => s.Length);
            foreach (var length in query)
            {
                Console.WriteLine(length);
            }


        }

    }
}
