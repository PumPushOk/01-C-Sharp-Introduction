using System.Net.NetworkInformation;

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
					if (text[i] == '.')
						isBeginning = true;
				}
			}
		}
	}
	static class Task7
	{
		private static string GetStars(int starsCount)
		{
			string result = string.Empty;
			while (starsCount > 0)
			{
				result += '*';
				starsCount--;
			}
			return result;
		}
		public static void Run()
		{
			Console.WriteLine("Enter a text:");
			//string text = Console.ReadLine();
			string text = "To be, or not to be, that is the question, Whether 'tis nobler in the mind to suffer The slings and arrows of outrageous fortune, Or to take arms against a sea of troubles, And by opposing end them? To die: to sleep; No more; and by a sleep to say we end The heart-ache and the thousand natural shocks That flesh is heir to, 'tis a consummation Devoutly to be wish'd. To die, to sleep";
			Console.WriteLine(text);
			Console.WriteLine();

			string[] badWords = { "die", "suffer", "to" };

			int[] statistics = new int[badWords.Length];
			string result = string.Empty;
			while (result.Length != text.Length)
			{
				string nextWord = string.Empty;
				int nextWordIndex = text.Length;
				foreach (string word in badWords)
				{
					int index = text.IndexOf(word, result.Length);
					if (index < nextWordIndex && index != -1)
					{
						nextWord = word;
						nextWordIndex = index;
					}
				}

				result += text.Substring(result.Length, nextWordIndex - result.Length);
				result += GetStars(nextWord.Length);

				for (int i = 0; i < badWords.Length; i++)
					if (badWords[i] == nextWord)
					{
						statistics[i]++;
						break;
					}
			}

			Console.WriteLine("Redacted text:");
			Console.WriteLine(result);

			Console.WriteLine();
			Console.WriteLine("Statistics:");
			for (int i = 0; i < statistics.Length; i++)
			{
				if (statistics[i] != 0)
					Console.WriteLine($"\t{statistics[i]} replacement of word \"{badWords[i]}\"");
			}
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			//Task5.Run();
			//Task6.Run();
			//Task7.Run();
		}

	}
}
