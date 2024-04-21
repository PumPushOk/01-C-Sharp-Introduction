using System;

 namespace C__Introduction
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Task1();
			Console.Clear();
			//Task2();
			Console.Clear();
		}
		static void Task1()
		{
			Console.Write("Enter a number: ");
			int num;
			num = int.Parse(Console.ReadLine());

			if (num > 0 && num <= 100)
				Console.WriteLine("Fizz");
			else
				Console.WriteLine("Buzz");
		}
		//static void Task2()
		//{
		//	Console.Write("Enter a number: ");
		//	int num;
		//	num = int.Parse(Console.ReadLine());

		//	if (num > 0 && num <= 100)
		//		Console.WriteLine("Fizz");
		//	else
		//		Console.WriteLine("Buzz");
		//}
	}
}










