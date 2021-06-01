using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excise2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 1 && args[0] == "-toi")
            {
                //インチからメートルへの対応表を出力
                PrintMeterToInchList(1, 10);
            }
            else
            {
                //インチからメートルへの対応力表を出力
                PrintInchToMeterList(1, 10);
            }

        }

        private static void PrintInchToMeterList(int start, int stop)
        {
            for (int meter = start; meter <= stop; meter++)
            {
                double Inch = InchConverter.FromMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000} Inch", meter, Inch);
            }
        }

        private static void PrintMeterToInchList(int start, int stop)
        {
            //フィートからメートルへの対応表を出力
            for (int Inch = start; Inch <= stop; Inch++)
            {
                double meter = InchConverter.FromMeter(Inch);
                Console.WriteLine("{0} Inch = {1:0.0000} m", Inch, meter);

            }
        }
    }
}
