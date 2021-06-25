using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace какулятор2.other
{
    public class Calculate
    {
        public static string Mod(string fo, string so)
        {
            double num1 = Convert.ToDouble(fo);
            double num2 = Convert.ToDouble(so);

            if ((num2 != 0))
            {
                return Convert.ToString((num1 % num2));
            }
            else if (num2 == 0)
            {
                return "Ошибка";
            }
            return "";
        }

        public static string Sqrt(string fo)
        {
            double num1 = Convert.ToDouble(fo);
            if (num1 >= 0)
            {
                return Convert.ToString(Math.Sqrt(num1));
            }
            else if (num1 < 0)
            {
                return "Ошибка";
            }
            return "";
            
        }

        public static double Pow(double fo, double so)
        {
            return (Math.Pow(fo, so));
        }

        public static string Fract(string fo)
        {
            double num = Convert.ToDouble(fo);
            if (num != 0)
            {
                return Convert.ToString(1 / num);
            }
            else if (num == 0)
            {
                return "Ошибка";
            }
            return "";
           
        }

        public static string Divide(string fo, string so)
        {
            double num1 = Convert.ToDouble(fo);
            double num2 = Convert.ToDouble(so);

            if ((num2 != 0))
            {
                return Convert.ToString((num1 / num2));
            }
            else if (num2 == 0)
            {
                return "Ошибка";
            }
            return "";
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
