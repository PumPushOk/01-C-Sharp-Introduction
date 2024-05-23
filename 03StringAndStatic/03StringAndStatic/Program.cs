namespace _03StringAndStatic
{
	static class Task5
	{
		public static void Run()
		{
			Console.Write("Enter a statement(with spaces): ");
			string[] statement = Console.ReadLine().Split();
			int num1 = int.Parse(statement[0]);
			char operation = char.Parse(statement[1]);
			int num2 = int.Parse(statement[2]);
			int result = 0;
			if (operation == '+') 
				result = num1 + num2;
			else if(operation == '-')
				result = num1 - num2;
			Console.WriteLine("Result is " + result);
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			//Task5.Run();
		}
	}
}
