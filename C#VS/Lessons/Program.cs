using System;
using System.Globalization;

namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //string str = "5";
            //string str2 = "2";

            //int strint = Convert.ToInt32(str);
            //int strint2 = Convert.ToInt32(str2);
            //Console.WriteLine(strint + strint2);
            //NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            //{
            //    NumberDecimalSeparator = ",",
            //};

            //string one_nine = "1,9";

            //double a = Convert.ToDouble(one_nine, numberFormatInfo);
            //Console.WriteLine(a);


            //Console.WriteLine("Enter the number!");
            //string bla = Console.ReadLine();

            //try
            //{
            //    int a = int.Parse(bla);
            //    Console.WriteLine($"Successful converstaion! {a}");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Unsuccessful conversation!");
            //}

            //int tryint;
            //bool res = int.TryParse(bla, out tryint);
            //if (res)
            //{
            //    System.Console.WriteLine($"Successful conversation! {tryint}");
            //}
            //else
            //{
            //    System.Console.WriteLine("Failure!");
            //}

            int sint = int.Parse(Console.ReadLine());

            switch (sint)
            {
                case 1:
                    Console.WriteLine("You wrote down digit 1");
                    break;
                case 2:
                    Console.WriteLine("You wrote down digit 2");
                    break;
                default:
                    Console.WriteLine($"You wrote down digit {sint}!!!");
                    break;
            }
        }
    }
}
