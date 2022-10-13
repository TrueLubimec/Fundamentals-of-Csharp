using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sup
{
    internal class Extra
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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



            ////ТРЕУГОЛЬНИКИ
            //for (int v = 0; v < 4; v++)
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        for (int a = 0; a < i + 1; a++)
            //        {
            //            Console.Write("#");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //    for (int i = 10; i > 0; i--)
            //    {
            //        for (int a = 0; a < i + 1; a++)
            //        {
            //            Console.Write("#");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}




            ////РАБОТА С МАССИВАМИ                                              РАБОТА С МАССИВАМИ
            //string[] strings = new string[5];

            //int vari;
            //int sum = 0;
            //int mini = int.MaxValue;
            //for (int i = 0; i < strings.Length;)
            //{
            //    string enteredNums = Console.ReadLine();
            //    if (enteredNums == "break" || i > 5) break;
            //    else
            //    {
            //        vari = int.Parse(enteredNums);
            //        sum = sum + vari;
            //        strings[i] = enteredNums;
            //        if (vari < mini)
            //        {
            //            mini = vari;
            //        }
            //        i++;
            //    }
            //}

            //Console.WriteLine();
            //for (int i = 5; i > 0; i--)
            //{
            //    Console.WriteLine(strings[i - 1]);
            //}
            //Console.WriteLine($"Summary = {sum}");
            //Console.WriteLine($"Minimal = {mini}");


            //// СОЗДАНИЕ КЛАССОВ(МЕТОДОВ)                                                  СОЗДАНИЕ КЛАССОВ(МЕТОДОВ)

            //char Lol = char.Parse(Console.ReadLine());
            //int times = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Printer(Lol, times);


            //int[] anArray = randomArray(5, -10, 20);
            //int bobina = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine(Jopa(anArray, bobina));


            ////ДОМАШКА ПО УДАЛЕНИЮ ЭЛЕМЕНТОВ                                               УДАЛЕНИЕ ЭЛЕМЕНТОВ

            //int[] anArray = { 1, 2, 3 };
            //delLastEl(ref anArray);
            //delFirstEl(ref anArray);
            //    for (int i = 0; i<anArray.Length; i++)
            //        Console.WriteLine(anArray[i]);
            //static void delFirstEl(ref int[] anArray)
            //{
            //    delElem(ref anArray, 0);
            //}
            //static void delLastEl(ref int[] anArray)
            //{
            //    delElem(ref anArray, anArray.Length - 1);
            //}
            //static void delElem(ref int[] anArray, int index)
            //{
            //    int[] extraArray = new int[anArray.Length - 1];
            //    for (int i = 0; i < index; i++)
            //        extraArray[i] = anArray[i];
            //    for (int a = index, len = anArray.Length - 1; a < len; a++)
            //        extraArray[a] = anArray[a + 1];
            //    anArray = extraArray;

            //// СОЗДАНИЕ КЛАССОВ(МЕТОДОВ)                                                      СОЗДАНИЕ КЛАССОВ(МЕТОДОВ)


            //static void Printer(char enteredPhrase, uint enteredTimes)
            //{
            //    for (int i = 0; i < enteredTimes; i++)
            //    {
            //        Console.WriteLine(enteredPhrase);
            //    }
            //}

            //static int[] randomArray (uint lengthOfArray, int minVal, int maxVal)
            //{
            //    int[] retArray = new int[lengthOfArray];
            //    Random random = new Random();
            //    for (int a = 0; a < lengthOfArray; a ++)
            //        retArray[a] = random.Next(minVal, maxVal);
            //    return retArray;
            //}
            //static int Jopa(int[] dubArray, int enteredNumber)
            //{
            //    for (int a = 0; a < dubArray.Length; a++)
            //    {
            //        if (dubArray[a] == enteredNumber)
            //        {
            //            return a;
            //        }
            //    }
            //    return -1;
            //}

            //int[] anArray = { 0, 1, 2, 3, 4, 5 };
            //int leng = anArray.Length - 1;
            //int sum = 0;
            //int amount = 0;

            //PrintArrayElements(in anArray, leng);
            //Console.WriteLine("---------------------");

            //AmountElements(in anArray, leng,ref amount);
            //Console.WriteLine(amount);
            //Console.WriteLine("---------------------");

            //SumElements(in anArray, ref sum, leng);
            //Console.WriteLine(sum);
            //Console.WriteLine("---------------------");


            //static void PrintArrayElements(in int[] anArray, int leng)
            //{
            //    Console.WriteLine(anArray[leng]);
            //    leng--;
            //    if (leng <= 0)
            //        return;
            //    PrintArrayElements(in anArray, leng);
            //}

            //static void AmountElements(in int[] anArray, int leng, ref int amount)
            //{
            //    if (leng < 0)
            //        return;
            //    amount++;
            //    leng--;
            //    AmountElements(in anArray, leng, ref amount);
            //}

            //static void SumElements(in int[] anArray, ref int sum, int leng)
            //{
            //    if (leng < 0)
            //        return;
            //    int var = anArray[leng];
            //    leng--;
            //    sum += var;
            //    SumElements(in anArray, ref sum, leng);
            //}


        }
    }
}
