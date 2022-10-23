// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;

class Program
{
	static void Main()
	{
		int Length = int.Parse(Console.ReadLine());
		string elem = Console.ReadLine();
		string[] anArray = new string[Length];
		try
		{
			int[] intArray = elem.Split(' ').Select(a => int.Parse(a)).ToArray();
            int answer = NOD(intArray[0], intArray[1]);
            int answer2 = NOD(intArray[2], intArray[3]);
            int answer3 = NOD(intArray[4], intArray[5]);
			Console.WriteLine(answer);
        }
		catch(Exception)
		{
            Console.WriteLine("1");
        }
	}
	static int NOD(int var1, int var2) {
		if (var1 == 0)	return var2;
		else { 
			while (var2 != 0)
			{
				if (var1 > var2)
					var1 -= var2;
				else
					var2 -= var1;
			}
			return var1;
		}
	}
}