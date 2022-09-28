// See https://aka.ms/new-console-template for more information
using System;

namespace Kontur
{
    class Program
    {
        static void Main(string[] argc)
        {

            //ЗАДАЧА Е

            int n = int.Parse(Console.ReadLine());
            string[] adress = new string[0] { };
            int[] num = new int[0] { };
            var dict = new Dictionary<int, string>();
            int keys = 0;
            for (int i = 0; i < n; i++)
            {
                Array.Resize(ref adress, adress.Length + 1);
                Array.Resize(ref num, num.Length + 1);
                adress[i] = Console.ReadLine();
                num[i] = int.Parse(Console.ReadLine());
                dict.Add(keys, adress[i]);
                keys++;
            }

            string[] names = new string[0] { };
            Console.WriteLine();
            int sheets = int.Parse(Console.ReadLine());
            for (int i = 0; sheets > 0; sheets--, i++)
            {
                int count = 0;
                Array.Resize(ref names, names.Length + 1);
                names[i] = Console.ReadLine();
                foreach (string entered in dict.Values)
                {
                    if (names[i] == entered | num[i] == i)
                    {
                        count++;
                    }
                    Console.WriteLine(count);
                }
            }


        }
    }
}
////ЗАДАЧА А

//string Number = Console.ReadLine();
//int[] numbersArray = { };
//if (Number != null)
//{
//    numbersArray = Number.Select(x => int.Parse(x.ToString())).ToArray();
//}

//int[] copyArray = Number.Select(x => int.Parse(x.ToString())).ToArray();
//int Max = int.MinValue;
//int Min = int.MaxValue;
//int[] Maximum = new int[numbersArray.Length];
//int[] Minimum = new int[numbersArray.Length];

//Console.WriteLine();

//int count = 0;
//while (numbersArray.Length > count)
//{
//    Maximum[count] = numbersArray.Max();
//    int maxx = numbersArray.Max();
//    numbersArray[Array.FindIndex(numbersArray, i => i == maxx)] = int.MinValue;
//    count++;
//}
//count = 0;
//while (copyArray.Length > count)
//{
//    Minimum[count] = copyArray.Min();
//    int minn = copyArray.Min();
//    copyArray[Array.FindIndex(copyArray, i => i == minn)] = int.MaxValue;
//    count++;
//}

//int var1 = 0;
//int var2 = 0;
//for (int a = 0; a < Maximum.Length; a++)
//{
//    var1 += Maximum[a] * Convert.ToInt32(Math.Pow(10, Maximum.Length - a - 1));
//}
//for (int b = 0; b < Minimum.Length; b++)
//{
//    var2 += Minimum[b] * Convert.ToInt32(Math.Pow(10, Minimum.Length - b - 1));
//}

//int k = var1 - var2;
//Console.WriteLine(k);


////РЕШЕНИЕ ЖЮРИ:
//public static void Main()
//{
//    var s = Console.ReadLine();
//    var charArray = s.ToCharArray();
//    var m = string.Concat(charArray.OrderBy(c => c));
//    var M = string.Concat(charArray.OrderByDescending(c => c));
//    Console.WriteLine(int.Parse(M) - int.Parse(m));
//}



////ЗАДАЧА Б

//int[] pares = new int[8] { 7, 1, -2, 1, 2, 3, -1, 0};
//int enteredVar = int.Parse(Console.ReadLine());
//if (enteredVar >= 1 && enteredVar <= 999)
//{
//    pares[^1] = enteredVar;
//    Console.WriteLine();

//    foreach (int i in pares)
//    {
//    Console.WriteLine(i);
//    }
//}


////ЗАДАЧА В

//Random random = new Random();
//int teams = random.Next(2, 20);
//Console.WriteLine(teams);
//int count = 1;
//for (;count <= teams; count++)
//{
//    Console.WriteLine(count);
//}