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
		string recieved = Console.ReadLine();
		double result = Calculate(recieved);
		Console.WriteLine(result);
		Thread.Sleep(10000);
	}
	protected static double Calculate (string recieved)
	{
		double[] intArray = recieved.Split(' ').Select(a => double.Parse(a)).ToArray();
		double vklad = intArray[0];
		double procentage = intArray[1];
		double srok = intArray[2];
		double kapital = vklad + Math.Pow(1 + ((procentage /100) * (12/100)), (int)srok);
		return Math.Round(kapital,1);
	}
}