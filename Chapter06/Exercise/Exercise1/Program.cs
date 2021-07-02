using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
   
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Console.WriteLine();
            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);
            var number = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            
           

            Console.ReadKey();

        }

        private static void Exercise1_5(int[] numbers)
        {
            Console.WriteLine(numbers.Distinct().Count(c => c >= 10));
           
        }

        private static void Exercise1_4(int[] numbers)
        {
            var s = numbers.OrderBy(c => c).Take(3);


            foreach (var item in s)
            {
                Console.WriteLine( item + ",");
            }

        }

        private static void Exercise1_3(int[] numbers)
        {
            /*
            var numStr = numbers.ToString();

            foreach (var item in numStr)
            {
                Console.Write($"{numStr}");
            }
            */
            Console.WriteLine(string.Join("," , numbers));
            Console.WriteLine();


        }

        private static void Exercise1_2(int[] numbers)
        {
            var tonton = numbers.Reverse().Take(2);
            foreach (var item in tonton)

            {
                Console.Write(item + ",");
            }

            Console.WriteLine();
        }

        private static void Exercise1_1(int[] numbers)
        {
            Console.WriteLine(numbers.Max(c => c));
        }

       

       


    }
}
