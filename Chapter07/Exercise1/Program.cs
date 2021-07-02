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
            var ton = "Cogy lummox gives smart squid who asks for job pen";

            Exercise_1(ton);
            Console.WriteLine("-----------");

            Exercise_2(ton);
            Console.WriteLine("------------");

        }

        private static void Exercise_2(string ton)
        {
            var dict = new SortedDictionary<char, int>();

            foreach (var item in ton)
            {
                var uc = char.ToUpper(item);
                if ('A' <= uc && uc <= 'Z')
                {
                    if (dict.ContainsKey(uc))
                    {
                        dict[uc]++;

                    }
                    else
                    {
                        dict[uc] = 1;
                    }
                }


            }
            foreach (var c in dict)
            {
                Console.WriteLine("'" + c.Key + "':" + c.Value);
            }


        }

        private static void Exercise_1(string ton)
        {
           

            var dict = new Dictionary<char, int>();

            foreach (var item in ton)
            {
                var uc = char.ToUpper(item);
                if ('A' <= uc && uc <= 'Z')
                {
                    if (dict.ContainsKey(uc))
                    {
                        dict[uc]++;

                    }
                    else
                    {
                        dict[uc] = 1;
                    }
                }

               
            }
            foreach (var c in dict.OrderBy(s =>s.Key))
            {
                Console.WriteLine( "'" + c.Key + "':" + c.Value );
            }
            
        }
    }
}

    
