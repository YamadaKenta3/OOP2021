﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter
{
    //フィートとメートルの単位変換クラス
    class FeetConverter
    {
        public double FromMeter(double meter)
        {
            //メートルからフィートを求める
            return meter / 0.3048;
        }

        //フィートからメートルを求める
        public double ToMeter(double feet)
        {
            return feet * 0.3048;
        }
    }
}
