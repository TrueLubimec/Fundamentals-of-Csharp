using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;

namespace Lessons
{
	internal class Basics
	{
		////ФУНКЦИИ И МЕТОДЫ                                                                ФУНКЦИИ И МЕТОДЫ

		//Создавать можно, где угодно. НО должен быть частью класса!!!!!!!!!!!!!

		// модификатор тип_возвращаемого_значения название_метода(параметры)
		// {
		//      тело метода
		// }
		// void используется, если не нужно возвращать.

		//static int summ(int var1, int var2)
		//{
		//    int res = var1 + var2;
		//    return res;
		//}
		//static void printer()
		//{
		//    Console.WriteLine("HURrAYyyYy");
		//}
		//static void PrRes(int res)
		//{
		//    Console.WriteLine(res);
		//}

		static void Main(string[] args)
		{
            //-------------------------------------------------
            //функции

            //Console.WriteLine("Hello, World!");
            //int var1 = int.Parse(Console.ReadLine());
            //int var2 = int.Parse(Console.ReadLine());

            //PrRes(summ(var1, var2));
            //printer();

            //=================================================

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

            //int sint = int.Parse(Console.ReadLine());

            //switch (sint)
            //{
            //    case 1:
            //        Console.WriteLine("You wrote down digit 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("You wrote down digit 2");
            //        break;
            //    default:
            //        Console.WriteLine($"You wrote down digit {sint}!!!");
            //        break;
            //}



            //ConsoleKey consoleKey = Console.ReadKey().Key;

            //switch (consoleKey)
            //{
            //    case ConsoleKey.Backspace:
            //        break;
            //    case ConsoleKey.Tab:
            //        break;
            //    case ConsoleKey.Clear:
            //        break;
            //    case ConsoleKey.Enter:
            //        break;
            //    case ConsoleKey.Pause:
            //        break;
            //    case ConsoleKey.Escape:
            //        break;
            //    case ConsoleKey.Spacebar:
            //        break;
            //    case ConsoleKey.PageUp:
            //        break;
            //    case ConsoleKey.PageDown:
            //        break;
            //    case ConsoleKey.End:
            //        break;
            //    case ConsoleKey.Home:
            //        break;
            //    case ConsoleKey.LeftArrow:
            //        break;
            //    case ConsoleKey.UpArrow:
            //        break;
            //    case ConsoleKey.RightArrow:
            //        break;
            //    case ConsoleKey.DownArrow:
            //        break;
            //    case ConsoleKey.Select:
            //        break;
            //    case ConsoleKey.Print:
            //        break;
            //    case ConsoleKey.Execute:
            //        break;
            //    case ConsoleKey.PrintScreen:
            //        break;
            //    case ConsoleKey.Insert:
            //        break;
            //    case ConsoleKey.Delete:
            //        break;
            //    case ConsoleKey.Help:
            //        break;
            //    case ConsoleKey.D0:
            //        break;
            //    case ConsoleKey.D1:
            //        break;
            //    case ConsoleKey.D2:
            //        break;
            //    case ConsoleKey.D3:
            //        break;
            //    case ConsoleKey.D4:
            //        break;
            //    case ConsoleKey.D5:
            //        break;
            //    case ConsoleKey.D6:
            //        break;
            //    case ConsoleKey.D7:
            //        break;
            //    case ConsoleKey.D8:
            //        break;
            //    case ConsoleKey.D9:
            //        break;
            //    case ConsoleKey.A:
            //        break;
            //    case ConsoleKey.B:
            //        break;
            //    case ConsoleKey.C:
            //        break;
            //    case ConsoleKey.D:
            //        break;
            //    case ConsoleKey.E:
            //        break;
            //    case ConsoleKey.F:
            //        break;
            //    case ConsoleKey.G:
            //        break;
            //    case ConsoleKey.H:
            //        break;
            //    case ConsoleKey.I:
            //        break;
            //    case ConsoleKey.J:
            //        break;
            //    case ConsoleKey.K:
            //        break;
            //    case ConsoleKey.L:
            //        break;
            //    case ConsoleKey.M:
            //        break;
            //    case ConsoleKey.N:
            //        break;
            //    case ConsoleKey.O:
            //        break;
            //    case ConsoleKey.P:
            //        break;
            //    case ConsoleKey.Q:
            //        break;
            //    case ConsoleKey.R:
            //        break;
            //    case ConsoleKey.S:
            //        break;
            //    case ConsoleKey.T:
            //        break;
            //    case ConsoleKey.U:
            //        break;
            //    case ConsoleKey.V:
            //        break;
            //    case ConsoleKey.W:
            //        break;
            //    case ConsoleKey.X:
            //        break;
            //    case ConsoleKey.Y:
            //        break;
            //    case ConsoleKey.Z:
            //        break;
            //    case ConsoleKey.LeftWindows:
            //        break;
            //    case ConsoleKey.RightWindows:
            //        break;
            //    case ConsoleKey.Applications:
            //        break;
            //    case ConsoleKey.Sleep:
            //        break;
            //    case ConsoleKey.NumPad0:
            //        break;
            //    case ConsoleKey.NumPad1:
            //        break;
            //    case ConsoleKey.NumPad2:
            //        break;
            //    case ConsoleKey.NumPad3:
            //        break;
            //    case ConsoleKey.NumPad4:
            //        break;
            //    case ConsoleKey.NumPad5:
            //        break;
            //    case ConsoleKey.NumPad6:
            //        break;
            //    case ConsoleKey.NumPad7:
            //        break;
            //    case ConsoleKey.NumPad8:
            //        break;
            //    case ConsoleKey.NumPad9:
            //        break;
            //    case ConsoleKey.Multiply:
            //        break;
            //    case ConsoleKey.Add:
            //        break;
            //    case ConsoleKey.Separator:
            //        break;
            //    case ConsoleKey.Subtract:
            //        break;
            //    case ConsoleKey.Decimal:
            //        break;
            //    case ConsoleKey.Divide:
            //        break;
            //    case ConsoleKey.F1:
            //        break;
            //    case ConsoleKey.F2:
            //        break;
            //    case ConsoleKey.F3:
            //        break;
            //    case ConsoleKey.F4:
            //        break;
            //    case ConsoleKey.F5:
            //        break;
            //    case ConsoleKey.F6:
            //        break;
            //    case ConsoleKey.F7:
            //        break;
            //    case ConsoleKey.F8:
            //        break;
            //    case ConsoleKey.F9:
            //        break;
            //    case ConsoleKey.F10:
            //        break;
            //    case ConsoleKey.F11:
            //        break;
            //    case ConsoleKey.F12:
            //        break;
            //    case ConsoleKey.F13:
            //        break;
            //    case ConsoleKey.F14:
            //        break;
            //    case ConsoleKey.F15:
            //        break;
            //    case ConsoleKey.F16:
            //        break;
            //    case ConsoleKey.F17:
            //        break;
            //    case ConsoleKey.F18:
            //        break;
            //    case ConsoleKey.F19:
            //        break;
            //    case ConsoleKey.F20:
            //        break;
            //    case ConsoleKey.F21:
            //        break;
            //    case ConsoleKey.F22:
            //        break;
            //    case ConsoleKey.F23:
            //        break;
            //    case ConsoleKey.F24:
            //        break;
            //    case ConsoleKey.BrowserBack:
            //        break;
            //    case ConsoleKey.BrowserForward:
            //        break;
            //    case ConsoleKey.BrowserRefresh:
            //        break;
            //    case ConsoleKey.BrowserStop:
            //        break;
            //    case ConsoleKey.BrowserSearch:
            //        break;
            //    case ConsoleKey.BrowserFavorites:
            //        break;
            //    case ConsoleKey.BrowserHome:
            //        break;
            //    case ConsoleKey.VolumeMute:
            //        break;
            //    case ConsoleKey.VolumeDown:
            //        break;
            //    case ConsoleKey.VolumeUp:
            //        break;
            //    case ConsoleKey.MediaNext:
            //        break;
            //    case ConsoleKey.MediaPrevious:
            //        break;
            //    case ConsoleKey.MediaStop:
            //        break;
            //    case ConsoleKey.MediaPlay:
            //        break;
            //    case ConsoleKey.LaunchMail:
            //        break;
            //    case ConsoleKey.LaunchMediaSelect:
            //        break;
            //    case ConsoleKey.LaunchApp1:
            //        break;
            //    case ConsoleKey.LaunchApp2:
            //        break;
            //    case ConsoleKey.Oem1:
            //        break;
            //    case ConsoleKey.OemPlus:
            //        break;
            //    case ConsoleKey.OemComma:
            //        break;
            //    case ConsoleKey.OemMinus:
            //        break;
            //    case ConsoleKey.OemPeriod:
            //        break;
            //    case ConsoleKey.Oem2:
            //        break;
            //    case ConsoleKey.Oem3:
            //        break;
            //    case ConsoleKey.Oem4:
            //        break;
            //    case ConsoleKey.Oem5:
            //        break;
            //    case ConsoleKey.Oem6:
            //        break;
            //    case ConsoleKey.Oem7:
            //        break;
            //    case ConsoleKey.Oem8:
            //        break;
            //    case ConsoleKey.Oem102:
            //        break;
            //    case ConsoleKey.Process:
            //        break;
            //    case ConsoleKey.Packet:
            //        break;
            //    case ConsoleKey.Attention:
            //        break;
            //    case ConsoleKey.CrSel:
            //        break;
            //    case ConsoleKey.ExSel:
            //        break;
            //    case ConsoleKey.EraseEndOfFile:
            //        break;
            //    case ConsoleKey.Play:
            //        break;
            //    case ConsoleKey.Zoom:
            //        break;
            //    case ConsoleKey.NoName:
            //        break;
            //    case ConsoleKey.Pa1:
            //        break;
            //    case ConsoleKey.OemClear:
            //        break;
            //    default:
            //        break;
            //}

            //int count = 0;
            //while (count < 10)
            //{
            //    ++count;
            //    Console.WriteLine($"Count = {count}");
            //}


            //for (;;)
            //{
            //    Console.WriteLine("Gays");
            //    System.Threading.Thread.Sleep(300);
            //    break;
            //}

            //int count = 0;
            //for (;count < 3; count++)
            //{
            //    Console.WriteLine($"For_1: {count}");
            //}
            //for(;count < 5; count++)
            //{
            //    Console.WriteLine($"For_2: {count}");
            //}

            //for(int i = 0, j = 0; i < 10 ; i++, j++)
            //{
            //    Console.WriteLine(j);
            //    Console.WriteLine(i);
            //}

            //for (int c = int.Parse(Console.ReadLine()); c >= 0; c--) // NOT RECOMMENDED
            //{
            //    Console.WriteLine($"Gays left {c}");
            //}


            /////ТРЕНАРНЫЕ ОПЕРАТОРЫ                                                          ТЕРНАРНЫЕ ОПЕРАТОРЫ

            //bool accessAllowed;

            //string standartPassword = "qwerty";
            //string enteredPassword = Console.ReadLine();

            //if (enteredPassword == standartPassword)
            //{
            //    accessAllowed = true;
            //}
            //else
            //{
            //    accessAllowed = false;
            //}

            //accessAllowed = enteredPassword == standartPassword ? true : false;

            //Console.WriteLine($"access = {accessAllowed}");

            //int inputData = int.Parse(Console.ReadLine());

            //int outputData = (inputData < 0) ? 0 : inputData;

            //Console.WriteLine(outputData);



            ////МАССИВЫ                                                                        МАССИВЫ
            //int[] myArray = new int[10];
            //myArray[0] = 1;
            //myArray[1] = 44;

            //int ArrVar = myArray[1];
            //Console.WriteLine(ArrVar);


            //int[] oneMoreArray = new int[5] { 1, 5, 5, 2, 5 }; // важно заполнить каждый слот при такой инициализации
            //int[] twoMoreArray = new int[] { 1, 5, 5 }; // так создаётся на столько слотов, сколько указано в фигурных скобках
            //int[] threeMoreArray = new[] { 1, 2, };
            //int[] fourMoreArray = { 1, 2, 3, 4, 555 };
            //int[] fiveMoreArray = Enumerable.Repeat(5, 10).ToArray();
            //int[] sixMoreArray = Enumerable.Range(4, 5).ToArray();

            //int[] anArray = { 1, 2, 3, 44, 2, 44, 77 };

            //for (int i = anArray.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(anArray[i]);
            //}

            //Console.WriteLine(anArray.Min());

            //Console.WriteLine(anArray.Max());
            //Console.WriteLine(anArray.Where(i => i % 2 == 0).Sum()); // сумма частных
            //int[] cock = anArray.Where(i => i < 70).ToArray();

            //int[] result = anArray.Distinct().ToArray(); //только уникальные элементы в массиве
            //Console.WriteLine(result.Length);

            //int[] sorted = anArray.OrderBy(i => i).ToArray(); //Сортировка по возрастанию
            //anArray.OrderByDescending(i => i).ToArray(); //по убыванию

            //Array.Sort(anArray); //у массивов много статический функций
            //int beb = Array.Find(anArray, i => i < 70); //поместит в переменную первую удволетворяющую 
            //Array.FindLast(anArray, i => i < 70); //просто поиск с конца
            //int[] meme = Array.FindAll(anArray, i => i < 70);

            //int bebe = Array.FindIndex(anArray, i => i == 44); //инедкс запрошенного элемента в массиве
            //int keke = Array.FindLastIndex(anArray, i => i == 44); //просто поиск с конца

            //Array.Reverse(anArray); //порядок на обратный


            ////ИНДЕКСЫ И ДИАПАЗОНЫ                                                         ИНДЕКСЫ И ДИАПАЗОНЫ

            //Работают ток на .Net Core (Lessons#2)


            ////Двумерный массив                                                            ДВУМЕРНЫЙ МАССИВ
            //int[,] dubArray = new int[3, 5];
            //dubArray[0,3] = 122;
            //Console.WriteLine(dubArray[0,3]);
            ////
            //Console.WriteLine();
            ////
            //int[,] dArray =
            //{
            //    { 1, 2,  3, 55, 23 },
            //    { 23,54, 12,42, 44},
            //    { 33,123,55,233,0},
            //    { 00,123,2,6513,44},
            //    { 5, 75, 89,53, 39}
            //};
            //Console.WriteLine(dArray[2,4]);

            //Console.WriteLine();
            //Console.WriteLine(dArray.Rank); //УЗНАТЬ КОЛЛИЧЕСТВО ИЗМЕРЕНИЙ 
            //Console.WriteLine();
            //int width = dArray.GetLength(1); //ДЛИНА СТРОКИ (0 - первое измерение, столбы; 1 - ВТОРОЕ ИЗМЕРЕНИЕ, строки)
            //int height = dArray.GetLength(0);//МОЖНО ОТДЕЛЬНО НЕ ОБЪЯВЛЯТЬ, А СРАЗУ В ЦИКЛЕ ПРОПИСАТЬ

            //СПОСОБ 1 вывод в таблицу
            //int count = 0;
            //foreach (var i in dArray)
            //{
            //    Console.Write($"{i}\t");
            //    count++;
            //    if (count >= width)
            //    {
            //        Console.WriteLine();
            //        count = 0;
            //    }
            //}

            // СПОСОБ 2
            //for (int b = 0; b < height; b++)
            //{
            //    for(int x = 0; x < width; x++)
            //    {
            //        Console.Write(dArray[b,x] + "\t");
            //    }
            //    Console.WriteLine();
            //}



            ////ЗАПОЛНЕНИЕ ДВУМЕРНОГО МАССИВА                                               ЗАПОЛНЕНИЕ ДВУМЕРНОГО МАССИВА

            //string[,] dumArray = new string[2, 3];

            //Random random = new Random();

            //for (int y = 0; y < dumArray.GetLength(0); y++)
            //{
            //    for (int x = 0; x < dumArray.GetLength(1); x++)
            //    {
            //        Console.WriteLine($"Enter the numeber to {y},{x} position");
            //        dumArray[y, x] = Console.ReadLine();
            //    }
            //}
            //Console.WriteLine();
            //for (int b = 0; b < dumArray.GetLength(0); b++)
            //{
            //    for (int x = 0; x < dumArray.GetLength(1); x++)
            //    {
            //        Console.Write(dumArray[b, x] + "\t");
            //    }
            //    Console.WriteLine();
            //}


            //// СТУПЕНЧАТЫЕ(ЗУБЧАТЫЕ) МАССИВЫ                                              СТУПЕНЧАТЫЕ(ЗУБЧАТЫЕ) МАССИВЫ
            //
            //int[][] anArray = new int[3]/* тут столбец основной */[] /* тут сами ступени */; //МАССИВ В МАССИВЕ
            // ВСЕГДА НЕОБХОДИМО ВЫДЕЛЯТЬ ПАМЯТЬ ДЛЯ ОСНОВОНОГО МАССИВА, ТАК КАК К НЕМУ ИДЁТ ОБРАЩЕНИЕ ОТ СТУПЕНЕЙ

            //anArray[0] = new int[3];// ТО ЕСТЬ ТУТ УЖЕ ОПРЕДЕЛЯЕМ СТУПЕНИ
            //anArray[1] = new int[6];
            //anArray[2] = new int[10];

            //int[,] dubArray = new int[10, 5];

            //int anArrayRank = anArray.Rank;
            //int dubArrayRank = dubArray.Rank;

            //int anArrayLength = anArray.Length;
            //int dubArrayLength = dubArray.Length;

            //ЗАПОЛНЕНИЕ И ВЫВОД

            //Random random = new Random();

            //for (int i = 0; i < anArray.Length; i++)
            //{
            //    for (int j = 0; j < anArray[i].Length /* ДЛИНА СТУПЕНИ(ВЛОЖЕННОГО МАССИВА) */; j++)
            //    {
            //        anArray[i][j] = random.Next(100);
            //    }
            //}

            //for (int i = 0; i < anArray.Length; i++)
            //{
            //    for (int j = 0; j < anArray[i].Length /* ДЛИНА СТУПЕНИ(ВЛОЖЕННОГО МАССИВА) */; j++)
            //    {
            //        ; Console.Write(anArray[i][j] + "\t");
            //    }
            //    Console.WriteLine();
            //}


            ////ТРЁХМЕРНЫЕ МАССИВЫ                                                           ТРЁХМЕРНЫЕ МАССИВЫ
            ///
            //int[,,] /* */ anArray = new int[2,/* СТРАНИЦА(Z) */ 5,/* СТРОКА(Y) */ 4 /* СТОЛБЕЦ(X) */];

            //int[,,] anIntArray =
            //{
            //    {
            //        {1, 2, 3, 4},
            //        {5,12,32,11 }
            //    },
            //    {
            //        {2, 24,74,72 },
            //        {51,50,64,72 }
            //    }

            //};

            //Random random = new Random();

            //for (int i = 0; i < anArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < anArray.GetLength(1); j++)
            //    {
            //        for (int b = 0; b < anArray.GetLength(2); b++)
            //        {
            //            anArray[i,j,b] = random.Next(100);
            //        }
            //    }
            //}
            //Console.WriteLine();
            //for (int i = 0; i < anArray.GetLength(0); i++)
            //{
            //    Console.WriteLine("==================================");
            //    Console.WriteLine($"Page #{i + 1}");
            //    for (int j = 0; j < anArray.GetLength(1); j++)
            //    {
            //        for (int b = 0; b < anArray.GetLength(2); b++)
            //        {
            //            Console.Write(anArray[i,j,b] + "\t");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine("==================================");
            //}

            //ЗУБЧАТЫЕ ТРЁХМЕРНЫЕ МАССИВЫ                                                   ЗУБЧАТЫЕ ТРЁХМЕРНЫЕ МАССИВЫ

            //Random random = new Random();

            //int[][][] zubArray = new int[random.Next(2, 6)][][];

            //for (int i = 0; i < zubArray.Length; i++)
            //{
            //    zubArray[i] = new int[random.Next(2, 6)][];

            //    for (int a = 0; a < zubArray[i].Length; a++)
            //    {
            //        zubArray[i][a] = new int[random.Next(2, 6)];

            //        for (int b = 0; b < zubArray[i][a].Length; b++)
            //        {
            //            zubArray[i][a][b] = random.Next(100);
            //        }

            //    }
            //}
            //Console.WriteLine();
            //for (int i = 0; i < zubArray.Length; i++)
            //{
            //    Console.WriteLine("==================================");
            //    Console.WriteLine($"Page #{i + 1}");

            //    for (int a = 0; a < zubArray[i].Length; a++)
            //    {

            //        for (int b = 0; b < zubArray[i][a].Length; b++)
            //        {
            //            Console.Write(zubArray[i][a][b] + "\t");
            //        }
            //        Console.WriteLine();

            //    }
            //    Console.WriteLine("==================================");
            //}

            //// ПЕРЕГРУЗКА МЕТОДОВ                                                         ПЕРЕГРУЗКА МЕТОДОВ

            ////ОН по сути даёт возможность реализовывать метод разными способами

            ///// <summary>
            ///// ТЕСТОВОЕ ОПИСАНИЕ
            ///// </summary>
            ///// <param name="a"></param>
            ///// <param name="b"></param>
            ///// <returns></returns>
            //static int Sum(int a, int b)
            //{
            //    // ТРИ слэша дают возможность описания кастомных методов
            //    int res = a + b;
            //    return res;
            //}
            //static int Sum(int a, int b, int c)
            //{
            //    int res = a + b + c;
            //    return res;
            //}
            //static double Sum(double a, double b)
            //{
            //    return a + b;
            //}
            //Console.WriteLine(Sum(55, 11));



            //// ОБЛАСТИ ВИДИМОСТИ | КОНТЕКСТ ПЕРЕМЕННОЙ

            //завивист от области инициализации


            //// ССЫЛОЧНЫЕ И ЗНАЧИМЫЕ ТИПЫ

            // по сути, в зависимости от типа будет выбрано ,где хранится: STACK or HEAP. Скрин есть в IPad.
            // тип показывается в IDE при указании курсором на сам "метод"

            //// ЧТО ТАКОЕ NULL

            // NULL - это отсутсвие свзяи(ссылки), поэтому может быть только в HEAP, но не в STACK(там реально значение)


            //// ОПЕРАТОР ОБЪЕДИНЕНИЯ С NULL                                                ОПЕРАТОР ОБЪЕДИНЕНИЯ С NULL

            //string result;

            //string str = null;

            //if (str == null)
            //    result = "нет данных";
            //else
            //    result = str;
            //Console.WriteLine(result);

            // но можно сдлеать через оператор 

            //string strr = null;
            //Console.WriteLine(strr ?? " нет данных ");


            //// ОПЕРАТОР ПРИСВАИВАНИЯ СО ЗНАЧЕНИЕМ NULL                                    ОПЕРАТОР ПРИСВАИВАНИЯ СО ЗНАЧЕНИЕМ NULL

            //string str = null;
            //str ??= string.Empty; //роюит на версии 8.0 и выше (тип фрэймворка)
            //Console.WriteLine($"The length of the string: {str.Length}");


            ////КЛЮЧЕВОЕ СЛОВО REF                                                          КЛЮЧЕВОЕ СЛОВО REF

            //через ref передаётся по ссылке, а не значению, т.е. не копируется а передаёт ссылку по координатам в памяти
            //int a = -2;
            //Foo(ref a);
            //Console.WriteLine(a);
            //При работе с массивами - по ref мы передаём саму оригинальную ссылку к данным, а не создаём ещё одну ссылку
            //поэтому если мы присовем NULL к ref - то рвём связь у обоих ярлыков и теряем данные.

            ////КЛЮЧЕВОЕ СЛОВО REF                                                          КЛЮЧЕВОЕ СЛОВО REF
            //    static void Foo(ref int a) //через ref передаётся по ссылка ,а не значению, т.е. не копируется а передаёт ссылку по координатам в памяти
            //    {
            //        a = -5;
            //    }


            ////КЛЮЧЕВОЕ СЛОВО OUT                                                          КЛЮЧЕВОЕ СЛОВО OUT

            //ОЧЕНЬ ПОХОЖЕ С REF. ПО ВЗАИМОДЕЙСТВИЮ С ССЫЛОЧНЫМИ ТИПАМИ - ИДЕНТИЧНО.
            //КЛЮЧЕВОЕ СЛОВО ГАРАНТИРУЕТ, ЧТО ПРИСВОЕТ ЗНАЧЕНИЕ. Если в метод REF мы передедим
            //переменную без присвоения(просто инициализация) - то он выдаст ошибку, так как 
            //ссылается на данные ,которых нет. OUT такой ошибки не даст.

            //string str = Console.ReadLine();
            //int.TryParse(str, out int value);
            //Console.WriteLine(value);


            ////КЛЮЧЕВОЕ СЛОВО IN                                                           КЛЮЧЕВОЕ СЛОВО IN
            // только с версии 7.2
            // Не даёт изменять внутри метода (READ-ONLY). Т.е. можем вытащить инфу, но
            // не изменить внутри переменной.
            // IN полезен, когда нужно считать данные(например - координаты),
            // а сами данные пострадать не должны + он позволяет оптимизровать работу.


            ////КЛЮЧЕВОЕ СЛОВО PARAMS                                                       КЛЮЧЕВОЕ СЛОВО PARAMS
            // Позволяет не делать перегрузку метода - т.е. передавать от 0 - до
            // множества элементов

            //parara("Fetish", 12, 45.5f, false);

            //static void parara(params object[] parameters)
            //{
            //    string message = "Data type {0}, value {1}";

            //    foreach (var parameter in parameters)
            //    {
            //        Console.WriteLine(message, parameter.GetType(), parameter);
            //    }
            //}


            ////НЕОБЯЗАТЕЛЬНЫЕ ПАРАМЕТРЫ МЕТОДА                                             МЕТОДЫ ПО УМОЛЧАНИЮ
            //  
            //Suka(14, 32);
            //static int Suka(int a, int b, bool enableLogging = false) //т.е. мы можем указать значение по умолчанию и тогда необязательно будет его передавать
            //{
            //    int result = a + b;

            //    if (enableLogging)
            //    {
            //        Console.WriteLine($"Значение a = {a}");
            //        Console.WriteLine($"Значение b = {b}");
            //        Console.WriteLine($"Result: {result}");
            //    }
            //    return result;
            //}


            ////ИМЕНОВАННЫЕ ПАРАМЕТРЫ                                                       ИМЕНОВАННЫЕ ПАРАМЕТРЫ

            //int bebra = Suka(b: 14, a: 32); //т.е. мы можем не идти по порядку, а указывать при вызове параметр и присваемое значение
            //static int Suka(int a, int b, bool enableLogging = false)
            //{
            //    int result = a + b;

            //    if (enableLogging)
            //    {
            //        Console.WriteLine($"Значение a = {a}");
            //        Console.WriteLine($"Значение b = {b}");
            //        Console.WriteLine($"Result: {result}");
            //    }
            //    return result;
            //}


            ////ЧТО ТАКОЕ РЕКУРСИЯ C#                                                       ЧТО ТАКОЕ РЕКУРСИЯ C#
            // вызов внутри цика этот же цикл.
            // Всё, что может цикл - может рекурсия.
            // Важно создавать условия выхода, или цикл будет бесконечным, а стэк перепонится.

            //Rec(0);

            //static void Rec(int i)
            //{
            //Thread.Sleep(300);
            //Console.WriteLine("Recursion");
            //Rec();

            //Console.WriteLine(i);
            //if (i >= 3)
            //    return;
            //i++;
            //Rec(i);
            //}


            //    Item aboba = InitItem();
            //    Print(aboba);

            //class Item
            //{
            //    public int Value { get; set; }
            //    public Item Child { get; set; } // Тут включает сам себя
            //}
            //static Item InitItem()
            //{
            //    return new Item()
            //    {
            //        Value = 5,
            //        Child = new Item()
            //        {
            //            Value = 10,
            //            Child = new Item()
            //            {
            //                Value = 20,
            //            }
            //        }
            //    };
            //}

            //static void Print(Item aboba)
            //{
            //    if (aboba != null)
            //    {
            //        Console.WriteLine(aboba.Value);
            //        Print(aboba.Child); // Рекурсия чтобы всё вызвать
            //    }
            //}



            ////ПРЕОБРАЗОВАНИЕ И ПРИВЕДЕНИЕ ТИПОВ                                           ПРЕОБРАЗОВАНИЕ И ПРИВЕДЕНИЕ ТИПОВ

            //double a = 5.3; //Занимает больше места в ОЗУ.
            //float b = (float)a; //для явного преобразования закдываем в скобки тип данных.
            //Мы не можем преобразовать из double в float, т.к. потенциально double может хранить больше или меньше ,чем float!!!

            //float z = 1.4F; // Если без суффикса F, то IDE по умолчанию думает - что это double.
            //double V = z;

            //Conv((float)a);
            //static void Conv(float var1)
            //{
            //    Console.WriteLine(var1);
            //}

            //Явно приведение типов(когда скобочки хуячим) - сужающее преобразование (тип дабл больше флоата)
            //Неявное(автоматическое) - расширяющее преобразование.

            //int ab = 5;
            //double bc = ab; 
            //byte beb = (byte)ab; //У байта от 0 - 255, у int - 999+. Поэтому мы можем потерять данные, если у инта будет больше данных чем лимит байта !!
            ////bool nub = (bool)ab; // Так не может, должны использовать класс новерт
            //bool nub = Convert.ToBoolean(bc);

            //int a = 2;
            //float b = 2.5F;
            //int result = (int)(a + b); //но мы потеряем дробную часть
            //Либо можно одну переменную, которая float - перевести во float.

            //Для string мы должны использовать класс Convert ,лмбо метод Parse



            ////АРИФМЕТИЧЕСКОЕ ПЕРЕПОЛНЕНИЕ                                                 АРИФМЕТИЧЕСКОЕ ПЕРЕПОЛНЕНИЕ

            //Если переполнится предел, то он выдаст другое значение в зависимости от границы.
            // тип если из byte со значением 1 вычесть 2 - то получится 255.

            // CHECKED и UNCHECKED
            // для проверки переполнения
            // Чтобы добавить на уровне проекта - то заходим в найстройки Проекта(замедляет проект).
            // Можем использовать ключевое слово checked, чтобы не на весь проект накидывать нагрузку
            //byte agr = 1;
            //byte dem = 2;
            //agr = checked((byte)(agr - dem)); // Будет давать ошибку.
            //checked
            //{
            //    // И сюда закидывать на проверку всё.
            //}
            //unchecked - если на весь проект стоит проверка (инвертированный прикол)

            //Чтобы не давало ошибку, можно юзать следующее:
            //try
            //{
            //    agr = checked((byte)(agr - dem));
            //    Console.WriteLine(agr);
            //}
            //catch(Exception)
            //{
            //    Console.WriteLine("э,зачем так делаешь");
            //}

            // У double и float нет переполнения!!!
            //double aboba = 1.0 / 0.0;
            //Console.WriteLine(double.IsInfinity(aboba)); //True

            //double buka = 0.0 / 0.0;
            //Console.WriteLine(double.IsNaN(buka)); //True

            //double las = double.MaxValue + double.MaxValue;
            //Console.WriteLine(double.IsInfinity(las)); //True

            // decimal вообще похую на проверки и он даёт всегда ошибку.



            //// ЧТО ТАКОЕ NULLABLE                                                         ЧТО ТАКОЕ NULLABLE

            //string str = null;
            //int? a = null;

            //DateTime? dateTime = null; // чтобы в значимый тип закинуть null - ставим знак вопроса после обозначения типа
            //Console.WriteLine(a);
            // После обозначения NULLABLE переменной - у неё появляется два новых поля
            // (HasValue - есть ли значение(TRUE/FALSE) и Value - реальные данные в NULLABLE переменной(сначала проверим пото вызывать эту фичу)

            // Способы проверки:
            //Console.WriteLine(a == null); // True

            //Console.WriteLine(a.HasValue); // False 

            //Console.WriteLine(a.GetValueOrDefault()); // 0 // ЕСЛИ НЕ NULLABLE - РАБОТАТЬ НЕ БУДЕТ

            //Console.WriteLine(a.GetValueOrDefault(3)); // 3

            //Console.WriteLine(a ?? 55); // 0

            //Console.WriteLine(a.Value); // InvalidOperationException

            // Если складывать int с NULLABLE - то при null будет NULL результатом операции.
            //int a = 5;
            //int? b = null;
            //Console.WriteLine(a > b); // И то , и то даст False
            //Console.WriteLine(a < b);



            ////ЧТО ТАКОЕ VAR. НЕЯВНО ТИПИЗИРОВАННЫЕ ЛОКАЛЬНЫЕ ПЕРЕМЕННЫЕ                   ЧТО ТАКОЕ VAR. НЕЯВНО ТИПИЗИРОВАННЫЕ ЛОКАЛЬНЫЕ ПЕРЕМЕННЫЕ
            // var не тип данных. Указывает компилятору, что нужно определить тип данных
            // Нельзя ставить другой тип в var, если уже был занесено значение типа.

            //var/* Dictionary<int, string> */ t = new Dictionary<int, string>();
            //Console.WriteLine(t.GetType());

            //Удобно юзать в анониманых типах данных
            //var t = new { Name = "Batikov", age = 99 };
            //Console.WriteLine(t.GetType());

            //int[] numv = { 1, 35, 1, 34, 5123512, 22, 5, 6, 7, 8, 9, };
            //var k = from i in numv where i > 15 select i;
            //foreach(var item in k)
            //{
            //    Console.WriteLine(item);
            //}



            ////ЧТО ТАКОЕ ENUM                                                              ЧТО ТАКОЕ ENUM 

            //while (true)
            //{
            //	ConsoleKey key = Console.ReadKey().Key;

            //	int keyCode = (int)key;

            //	Console.WriteLine($"\tEnum {key}\t Key Code {keyCode}");

            //	if (key == ConsoleKey.Enter)
            //	{
            //		Console.WriteLine("U pressed Enter");
            //	}
            //}

            //WeekDay day = WeekDay.Monday;

            //Console.WriteLine(Enum.GetUnderlyingType(typeof(WeekDay)));

            //int dayKey = (int)day;
            //Console.WriteLine($"{day}, {dayKey}"); 
            //Console.WriteLine((WeekDay)3); //Приводим int к WeekDay (покажет к какому ENUM-объекту относится 3)

            //WeekDay newday;
            //int value = 66; //Если в ENUM передаётся тип данных, то он должен быть таким же, как и ENUM!!!
            //if (Enum.IsDefined(typeof(WeekDay)/*ТУТ ПЕРЕДАЁМ ТИП ДАННЫХ ENUM*/, (byte)value)) // Для проверки если есть в ENUM такое место, чтобы логику не сломать.
            //{
            //	newday = (WeekDay)value; 
            //}
            //else
            //{
            //	throw new Exception("Ты инвалид");
            //}
            //Console.WriteLine(newday);

            //var values = Enum.GetValues(typeof(WeekDay)/*ТУТ ПЕРЕДАЁМ ТИП ДАННЫХ ENUM*/); //ВЫВОДИМ ВСЕ ДАННЫЕ
            //foreach (var day in values)
            //{
            //	Console.WriteLine(day);
            //}

            //         string str = Console.ReadLine();
            //WeekDay DAY = (WeekDay)Enum.Parse(typeof(WeekDay), str, ignoreCase: true/*ИГНОРИРУЕТ ЗАГЛАВНЫЕ ЛИ ИЛИ ПРОПИСНЫЕ*/);
            //Console.WriteLine(DAY);

            //         switch (DAY)
            //         {
            //             case WeekDay.Monday:
            //                 break;
            //             case WeekDay.Tuesday:
            //                 break;
            //             case WeekDay.Wednesday:
            //                 break;
            //             case WeekDay.Thursday:
            //                 break;
            //             case WeekDay.Friday:
            //                 break;
            //             case WeekDay.Saturday:
            //                 break;
            //             case WeekDay.Sunday:
            //                 break;
            //             default:
            //                 break;
            //         }

            //     enum WeekDay : byte //После двоеточия МОЖНО изменить тип данных для ENUM, но необязательно
            //     {
            //         Monday = 1,
            //         Tuesday,
            //         Wednesday,
            //         Thursday,
            //         Friday,
            //         Saturday,
            //         Sunday
            //     }
        }
        static int Decode(string recieved)
        {
            int[] anArray = new int[recieved.Length];
            int counter = 0;
            int number;
            bool check;
            foreach (char var1 in recieved)
            {
                string var2 = Convert.ToString(var1);
                if (check = int.TryParse(var2, out number))
                {
                    anArray[counter] = number;
                    counter++;
                }
            }
            int[] secondArray = new int[counter];
            for (int c2 = 0; c2 < counter; c2++)
            {
                secondArray[c2] = anArray[c2];
            }
            int result = 0;
            for (int i = 0; i < secondArray.Length; i++)
            {
                result += secondArray[i] * Convert.ToInt32(Math.Pow(10, secondArray.Length - i - 1));
            }
            return result;
        }
    }
}   
