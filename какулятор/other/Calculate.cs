using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace какулятор2.other
{
    public class Calculate
    {
        public static double Div(double fo, double so)
        {
            return (fo % so);
        }
        public static double Sqrt(double fo)
        {
            return (Math.Sqrt(fo));
        }
        public static double Pow(double fo, double so)
        {
            return (Math.Pow(fo, so));
        }
        public static double Fract(double fo)
        {
            return (1 / fo);
        }
        public static double Divide(double fo, double so)
        {
            return (fo / so);
        }
        public static double Multiply(double fo, double so)
        {
            return (fo * so);
        }
        public static double Minus(double fo, double so)
        {
            return (fo - so);
        }
        public static double Plus(double fo, double so)
        {
            return (fo + so);
        }
    }
}
