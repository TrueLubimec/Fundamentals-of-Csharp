// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

namespace Kontur
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var builder = new StringBuilder();
            var data = new Dictionary<string, List<int>>();
            for (int i = 0; i < n; i++)
            {
                var s = Console.ReadLine();
                int index = Enumerable.Range(0, s.Length).First(j => char.IsDigit(s[j]));
                var name = s.Substring(0, index);
                var number = int.Parse(s.Substring(index));
                if (!data.ContainsKey(name))
                    data[name] = new List<int>();
                data[name].Add(number);
            }

            var dataQueues = data.ToDictionary
            (
                kvp => kvp.Key,
                kvp => new Queue<int>(kvp.Value.OrderBy(x => x))
            );

            var firstFree = new Dictionary<string, int>();
            int q = int.Parse(Console.ReadLine());
            for (int i = 0; i < q; i++)
            {
                var query = Console.ReadLine();
                var candidate = firstFree.ContainsKey(query) ? firstFree[query] : 1;

                if (dataQueues.ContainsKey(query))
                {
                    var queue = dataQueues[query];
                    while (queue.Count > 0 && queue.Peek() == candidate)
                    {
                        candidate++;
                        queue.Dequeue();
                    }
                }

                builder.AppendLine(candidate.ToString());
                firstFree[query] = candidate + 1;
            }

            Console.Write(builder);
        }
    }
}
////ЗАДАЧА А                                                                                    ЗАДАЧА А

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


////РЕШЕНИЕ ЖЮРИ:                                                                               РЕШЕНИЕ ЖЮРИ
//public static void Main()
//{
//    var s = Console.ReadLine();
//    var charArray = s.ToCharArray();
//    var m = string.Concat(charArray.OrderBy(c => c));
//    var M = string.Concat(charArray.OrderByDescending(c => c));
//    Console.WriteLine(int.Parse(M) - int.Parse(m));
//}


////ЗАДАЧА C

//public static void Main()
//{
//    int n = int.Parse(Console.ReadLine());
//    var table = new List<(string, int)>();
//    for (int i = 0; i < n; i++)
//    {
//        var tokens = Console.ReadLine().Split();
//        table.Add((tokens[0], int.Parse(tokens[1])));
//    }

//    var teams = Console.ReadLine().Split('-');

//    int res1 = Solve(table.ToArray(), teams[0], 3, teams[1], 0);
//    int res2 = Solve(table.ToArray(), teams[0], 1, teams[1], 1);
//    int res3 = Solve(table.ToArray(), teams[0], 0, teams[1], 3);
//    Console.WriteLine(res1 + " " + res2 + " " + res3);
//}

//private static int Solve((string, int)[] table, string team1, int p1, string team2, int p2)
//{
//    int index1 = Enumerable.Range(0, table.Length).First(i => table[i].Item1 == team1);
//    table[index1] = (table[index1].Item1, table[index1].Item2 + p1);

//    int index2 = Enumerable.Range(0, table.Length).First(i => table[i].Item1 == team2);
//    table[index2] = (table[index2].Item1, table[index2].Item2 + p2);

//    table = table.OrderByDescending(item => item.Item2).ThenBy(item => item.Item1).ToArray();
//    return Enumerable.Range(0, table.Length).First(i => table[i].Item1 == team1) + 1;
//}



////ЗАДАЧА D                                                                                    ЗАДАЧА D

//var ints = Console.ReadLine()
//    .Split()
//    .Select(int.Parse)
//    .ToArray();
//int n = ints[0];
//int m = ints[1];
//var map = new string[n];
//for (int i = 0; i < n; i++)
//    map[i] = Console.ReadLine();

//var maxPrefix = new int[n + 1][];
//for (int i = 0; i <= n; i++)
//    maxPrefix[i] = new int[m + 1];

//for (int i = 1; i < n; i++)
//    for (int j = 1; j < m; j++)
//    {
//        if (map[i][j] == '*')
//            maxPrefix[i][j] = 0;
//        else
//            maxPrefix[i][j] = maxPrefix[i][j - 1] + 1;
//    }

//int max = 0;
//for (int i = 1; i + 1 < n; i++)
//    for (int j = 1; j + 1 < m; j++)
//        if (map[i][j] == '.')
//        {
//            int width = n * m;
//            for (int h = i; h > 0; h--)
//            {
//                width = Math.Min(maxPrefix[h][j], width);
//                if (width * (i - h + 1) > max)
//                    max = width * (i - h + 1);
//            }
//        }

//Console.WriteLine(max);


////ЗАДАЧА E                                                                                    ЗАДАЧА E

//int n = int.Parse(Console.ReadLine());
//var builder = new StringBuilder();
//var data = new Dictionary<string, List<int>>();
//for (int i = 0; i < n; i++)
//{
//    var s = Console.ReadLine();
//    int index = Enumerable.Range(0, s.Length).First(j => char.IsDigit(s[j]));
//    var name = s.Substring(0, index);
//    var number = int.Parse(s.Substring(index));
//    if (!data.ContainsKey(name))
//        data[name] = new List<int>();
//    data[name].Add(number);
//}

//var dataQueues = data.ToDictionary
//(
//    kvp => kvp.Key,
//    kvp => new Queue<int>(kvp.Value.OrderBy(x => x))
//);

//var firstFree = new Dictionary<string, int>();
//int q = int.Parse(Console.ReadLine());
//for (int i = 0; i < q; i++)
//{
//    var query = Console.ReadLine();
//    var candidate = firstFree.ContainsKey(query) ? firstFree[query] : 1;

//    if (dataQueues.ContainsKey(query))
//    {
//        var queue = dataQueues[query];
//        while (queue.Count > 0 && queue.Peek() == candidate)
//        {
//            candidate++;
//            queue.Dequeue();
//        }
//    }

//    builder.AppendLine(candidate.ToString());
//    firstFree[query] = candidate + 1;
//}

//Console.Write(builder);