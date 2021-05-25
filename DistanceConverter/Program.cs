﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 1 && args[0] == "-tom")
            {
                PrintFeetToMeterList(1,10);
            }else{
                //メートルからフィートへの対応力表を出力
                PrintMeterToFeetList(1,10);
            }

        }

        private static void PrintMeterToFeetList(int start,int stop)
        {
            FeetConverter converter = new FeetConverter();
            for (int meter = start; meter <= stop; meter++)
            {
                double feet = converter.ToMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000} ft", meter, feet);
            }
        }

        private static void PrintFeetToMeterList(int start ,int stop)
        {
            FeetConverter converter = new FeetConverter();
            //フィートからメートルへの対応表を出力
            for (int feet = start; feet <= stop; feet++)
            {
                double meter = converter.ToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);

            }
        }
        

    }
}
