using System;
using System.Globalization;

namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string str = "5";
            string str2 = "2";

            int strint = Convert.ToInt32(str);
            int strint2 = Convert.ToInt32(str2);
            Console.WriteLine(strint + strint2);
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ",",
            };

            string one_nine = "1,9";

            double a = Convert.ToDouble(one_nine, numberFormatInfo);
            Console.WriteLine(a);
        }
    }
}
