using System;
using System.Collections.Specialized;
using System.Linq;
using System.Threading;

namespace C__Introduction
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Task1();
			//Task2();
			//Task3();
			//Task4();
			//Task5();
			//Task6();
			//Task7();
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
			Console.Write("Enter a value: ");
			float value = float.Parse(Console.ReadLine());

			Console.Write("Enter a percentage: ");
			float percent = float.Parse(Console.ReadLine());

			float result = value * percent / 100;
			Console.WriteLine($"Result is {result}");
		}
		static void Task3()
		{
			Console.WriteLine("You need to enter 4 digits!");
			int result = 0;
			for (int i = 0; i < 4; i++)
			{
				Console.Write("Enter a digit: ");
				int num = int.Parse(Console.ReadLine());
				if (num > 9)
				{
					Console.WriteLine("You should enter only one digit!");
					return;
				}

				result *= 10;
				result += num;
			};
			Console.WriteLine($"Result is {result}");
		}
		static void Task4()
		{
			Console.Write("Enter a 6-digit number: ");
			int inputNum = int.Parse(Console.ReadLine());
			if (inputNum.ToString().Length != 6)
			{
				Console.WriteLine("Wrong number!");
				return;
			}

			Console.Write("Enter a first position: ");
			int firstPos = int.Parse(Console.ReadLine());
			if (firstPos < 1 || firstPos > 6)
			{
				Console.WriteLine("Wrong position!");
				return;
			}
			Console.Write("Enter a second position: ");
			int secondPos = int.Parse(Console.ReadLine());
			if (secondPos < 1 || secondPos > 6)
			{
				Console.WriteLine("Wrong position!");
				return;
			}

			int result = 0;
			for (int i = 1; i <= 6; i++)
			{
				if (i == firstPos)
					result += inputNum % (int)Math.Pow(10, secondPos) / (int)Math.Pow(10, secondPos - 1) * (int)Math.Pow(10, i - 1);
				else if (i == secondPos)
					result += inputNum % (int)Math.Pow(10, firstPos) / (int)Math.Pow(10, firstPos - 1) * (int)Math.Pow(10, i - 1);
				else
					result += inputNum % (int)Math.Pow(10, i) / (int)Math.Pow(10, i - 1) * (int)Math.Pow(10, i - 1);
			}

			Console.WriteLine($"Result is {result}");
		}
		static void Task5()
		{

			Console.Write("Enter a date(dd.mm.yyyy): ");
			if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
			{

				string monthName = "";
				switch (date.Month)
				{
					case 12:
					case 1:
					case 2:
						monthName = "Winter";
						break;
					case 3:
					case 4:
					case 5:
						monthName = "Spring";
						break;
					case 6:
					case 7:
					case 8:
						monthName = "Summer";
						break;
					case 9:
					case 10:
					case 11:
						monthName = "Outumn";
						break;
				}
				Console.WriteLine($"{monthName} {date.DayOfWeek}");
			}
			else
			{ Console.WriteLine("Error with date!"); }
		}
		static void Task6()
		{
			Console.Write("Enter a temperature(number): ");
			if (float.TryParse(Console.ReadLine(), out float temperature))
			{
				Console.WriteLine("1 - Convert to Celsius");
				Console.WriteLine("2 - Convert to Fahrenheit");
				Console.WriteLine("Your choice: ");
				if (int.TryParse(Console.ReadLine(), out int choice))
				{
					switch (choice)
					{
						case 1:
							temperature = (temperature - 32) * 5 / 9;
							break;
						case 2:
							temperature = temperature * 9 / 5 + 32;

							break;
						default:
							Console.WriteLine("Wrong choice!");
							return;
					}
					Console.WriteLine($"Result is {temperature}");
				}
			}
		}
		static void Task7()
		{
			Console.Write("Enter first number: ");
			if (!int.TryParse(Console.ReadLine(), out int num1))
			{
				Console.WriteLine("Enter a num!");
			}
			Console.Write("Enter second number: ");
			if (!int.TryParse(Console.ReadLine(), out int num2))
			{
				Console.WriteLine("Enter a num!");
			}
			if (num1 > num2)
			{
				int temp = num1;
				num1 = num2;
				num2 = temp;
			}
			for (int i = num1; i < num2; i++)
			{
				if (i % 2 == 0)
					Console.Write(i + " ");
			}
			Console.WriteLine();
		}
	}
}










