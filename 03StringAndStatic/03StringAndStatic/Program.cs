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
			else if (operation == '-')
				result = num1 - num2;
			Console.WriteLine("Result is " + result);
		}
	}
	static class Task6
	{
		public static void Run()
		{
			Console.WriteLine("Enter a text:");
			string text = Console.ReadLine();
			bool isBeginning = true;
			for (int i = 0; i < text.Length; i++)
			{
				if (char.IsAsciiLetter(text[i]) && isBeginning)
				{
					Console.Write(char.ToUpper(text[i]));
					isBeginning = false;
				}
				else
				{
					Console.Write(text[i]);
					if(text[i] == '.')
						isBeginning = true;
				}
			}
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			//Task5.Run();
			//Task6.Run();
		}

	}
}
