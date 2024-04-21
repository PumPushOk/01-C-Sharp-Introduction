using System;

namespace C__Introduction
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Task1();
			Console.Clear();
			Task2();
			Console.Clear();
		}
		static void Task1()
		{
			Console.Write("Enter a number: ");
			int num;
			num = int.Parse(Console.ReadLine());

			if (num < 1 || num > 100)
			{
				Console.WriteLine("Error!");
				return;
			}

			bool isMultipleOfThree = false;
			if (num % 3 == 0)
				isMultipleOfThree = true;

			bool isMultipleOfFive = false;
			if (num % 5 == 0)
				isMultipleOfFive = true;

			if (isMultipleOfThree)
				Console.Write("Fizz");
			if (isMultipleOfFive)
				Console.Write("Buzz");
			if (!isMultipleOfThree && !isMultipleOfFive)
				Console.Write(num);
			Console.WriteLine();
		}
		static void Task2()
		{
		
		}
	}
}










