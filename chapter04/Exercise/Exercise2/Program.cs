using Exercise1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region YearMonth[]
            var ymCollection = new YearMonth[]
            {
              new YearMonth(1980,1),new YearMonth(1990,4),new YearMonth(2000,7),
              new YearMonth(2010,9),
              new YearMonth(2020,12),
            };
            #endregion
            #region Exercise2_2
            Exercise2_2(ymCollection);
            Console.WriteLine("---");
            #endregion
            #region Exercise2_4
            Exercise2_4(ymCollection);
            Console.WriteLine("---");
            #endregion
            #region Exercise2_5
            Exercise2_5(ymCollection);
            Console.WriteLine("---");
            #endregion
        }
        #region 2_2
        private static void Exercise2_2(YearMonth[] ymCollection)
        {
            foreach(var item in ymCollection)
            {
                Console.WriteLine(item);
            }
        }
        #endregion
        #region 21C
        static YearMonth FindFirst21C(YearMonth[] yms)
        {
            foreach (var a in yms)
            {
                if (a.Is21Century)
                {
                    return a;
                }
                
            }
            return null;
        }
        #endregion
        #region 2_4
        private static void Exercise2_4(YearMonth[] ymCollection)
        {
            var Is21 = ymCollection.Contains(FindFirst21C(ymCollection)) ?
                FindFirst21C(ymCollection).Year.ToString() : "21世紀のデータは見つかりませんでした。";
            Console.WriteLine(Is21);

        }
        #endregion
        #region 2_5
        private static void Exercise2_5(YearMonth[] ymCollection)
        {
           
            ymCollection.Select(x => x.AddOneMonth()).ToList().ForEach(Console.WriteLine);
            
            
            //foreach (var item in OneMonthLater) Console.WriteLine(item);
        }
        #endregion
    }
}
