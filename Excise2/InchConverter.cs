using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excise2

{
    //フィートとメートルの単位変換クラス
    public static class InchConverter
    {
        private const double ratio = 0.0254;

        public static double FromMeter(double meter)
        {
            //メートルからインチを求める
            return meter / ratio;
        }

        //インチからメートルを求める
        public static  double ToMeter(double feet)
        {
            return feet * ratio;
        }
    }
}
