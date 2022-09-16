// See https://aka.ms/new-console-template for more information
using System;

namespace Lessons_core
{
    class Program
    {
        static void Main(string[] argc)
        {
            //// Индексы и диапазоны в C#                                                   Индексы и диапазоны в C#
            //int[] anArray = { 2, 44, 51, 22 };

            //Console.WriteLine(anArray[^1]);
            //int[] beb = anArray[1..4];
            //int[] aa = anArray[..3]; //с самого начала и до 3

            //Index anIndex = ^2;
            //Console.WriteLine(anArray[anIndex]);

            //Console.WriteLine($"value {anIndex.Value} isFromEnd {anIndex.IsFromEnd}");
            
            //Range aRange = new Range();
            //int[] anArray2 = anArray[aRange];
            //Range range = ^4..^1;
            //Console.WriteLine();
            //Console.WriteLine();

            string str = "Hello World!";
            Console.WriteLine(str[1]);
        }
    }
}