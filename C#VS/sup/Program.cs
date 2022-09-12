using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Calculator! Enter the expression!");
            //string expression = Console.ReadLine();

            //string[] dig = expression.Split(' ');

            //int var1 = Convert.ToInt32(dig[0]);
            //int var2 = Convert.ToInt32(dig[2]);
            //string symb1 = dig[1];
            //int ret;
            //switch (symb1)
            //{
            //    case "+":
            //        ret = var1 + var2;
            //        Console.WriteLine($"The result is {ret}");
            //        break;
            //    case "-":
            //        ret = var1 - var2;
            //        Console.WriteLine($"The result is {ret}");
            //        break;
            //    case "*":
            //        ret = var1 * var2;
            //        Console.WriteLine($"The result is {ret}");
            //        break;
            //    case "/":
            //        ret = var1 / var2;
            //        Console.WriteLine($"The result is {ret}");
            //        break;
            //    default:
            //        Console.WriteLine("Wrong expression!");
            //        break;
            //)




            //Console.WriteLine("Enter the range!");
            //string dig = Console.ReadLine();
            //string[] range = dig.Split(' ');
            //int.TryParse(range[0], out int min);
            //int.TryParse(range[1], out int max);
            //int count = min;
            //int evenCount = 0;
            //int oddCount = 0;
            //int oddSum = 0;
            //int evenSum = 0;
            //while (count <= max)
            //{
            //    if (count % 2 == 0)
            //    {
            //        evenCount++;
            //        evenSum = evenSum + count;
            //        count++;
            //    }
            //    else
            //    {
            //        oddCount++;
            //        oddSum = oddSum + count;
            //        count++;
            //    }
            //}

            //Console.WriteLine($"evens sum = {evenSum}, odds sum = {oddSum}");
            //Console.WriteLine($"evens = {evenCount}, odds = {oddCount}");



            //ТРЕУГОЛЬНИКИ
            for (int v = 0; v < 4; v++)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int a = 0; a < i + 1; a++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int i = 10; i > 0; i--)
                {
                    for (int a = 0; a < i + 1; a++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }


        }
    }
}
