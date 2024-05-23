namespace _02ArraysAndString
{
	static class Task1
	{
		static int FindMax(Array array)
		{
			int maxNum = int.MinValue;
			foreach (int num in array)
			{
				if (num > maxNum)
				{
					maxNum = num;
				}
			}
			return maxNum;
		}
		static int FindMin(Array array)
		{
			int minNum = int.MaxValue;
			foreach (int num in array)
			{
				if (num < minNum)
				{
					minNum = num;
				}
			}
			return minNum;
		}
		static int FindSum(Array array)
		{
			int sum = 0;
			foreach (int num in array)
			{
				sum += num;
			}
			return sum;
		}
		static long FindProduct(Array array)
		{
			long product = 1;
			foreach (int num in array)
			{
				product *= num;
			}
			return product;
		}
		public static void Run()
		{
			Console.Write("Enter a 5 numbers(using space): ");
			int[] nums1 = new int[5];
			string[] splitted1 = Console.ReadLine().Split(' ');
			for (int i = 0; i < nums1.Length; i++)
			{
				nums1[i] = int.Parse(splitted1[i]);
			}
			Console.WriteLine("Max = " + FindMax(nums1));
			Console.WriteLine("Min = " + FindMin(nums1));
			Console.WriteLine("Sum = " + FindSum(nums1));
			Console.WriteLine("Product = " + FindProduct(nums1));
			int evenSum = 0;
			for (int i = 0; i < nums1.Length; i++)
			{
				if (i % 2 == 0)
					evenSum += nums1[i];
			}
			Console.WriteLine("Even Sum = " + evenSum);
			Console.WriteLine();

			Console.WriteLine("Second array:");
			int[,] nums2 = new int[3, 4];
			for (int i = 0; i < nums2.GetLength(0); i++)
			{
				for (int j = 0; j < nums2.GetLength(1); j++)
				{
					nums2[i, j] = Random.Shared.Next(100);
					Console.Write(nums2[i, j] + " ");
				}
				Console.WriteLine();
			}
			Console.WriteLine("Max = " + FindMax(nums2));
			Console.WriteLine("Min = " + FindMin(nums2));
			Console.WriteLine("Sum = " + FindSum(nums2));
			Console.WriteLine("Product = " + FindProduct(nums2));
			int oddSum = 0;
			for (int i = 0; i < nums2.GetLength(0); i++)
			{
				for (int j = 0; j < nums2.GetLength(1); j++)
				{
					if (j % 2 == 1)
					{
						oddSum += nums2[i, j];
					}
				}
			}
			Console.WriteLine("Odd Sum = " + oddSum);
		}
	}
	static class Task2
	{
		public static void Run()
		{
			int[,] nums = new int[5, 5];
			for (int i = 0; i < nums.GetLength(0); i++)
			{
				for (int j = 0; j < nums.GetLength(1); j++)
				{
					nums[i, j] = Random.Shared.Next(-100, 101);
					Console.Write(nums[i, j] + " ");
				}
				Console.WriteLine();
			}
			int min = int.MaxValue;
			int max = int.MinValue;
			foreach (int i in nums)
			{
				if (i < min)
					min = i;
				if (i > max)
					max = i;
			}
			Console.WriteLine("Min = " + min);
			Console.WriteLine("Max = " + max);

			int start = 0;
			int finish = 0;
			foreach (int i in nums)
			{
				if (i == min || i == max)
				{
					start = i;
					if (i != min)
						finish = min;
					else
						finish = max;
					break;
				}
			}
			Console.WriteLine("Start = " + start);
			Console.WriteLine("Finish = " + finish);

			int sum = 0;
			bool isStarted = false;
			bool isEnd = false;
			for (int i = 0; i < nums.GetLength(0); i++)
			{
				for (int j = 0; j < nums.GetLength(1); j++)
				{
					if (nums[i, j] == finish)
					{
						isEnd = true;
						break;
					}
					if (isStarted)
					{
						sum += nums[i, j];
					}
					if (nums[i, j] == start)
					{
						isStarted = true;
					}
				}
				if (isEnd)
					break;
			}
			Console.WriteLine("Sum = " + sum);
		}
	}
	static class Task3
	{
		private static string Encrypt(string input, int length)
		{
			string result = null;
			foreach (char c in input)
			{
				if (!char.IsLetter(c))
					continue;
				char symbol = Convert.ToChar((c + length));
				if (symbol > 'z')
					symbol -= Convert.ToChar('z' - 'a' + 1);
				else if (symbol > 'Z' && symbol < 'a')
					symbol -= Convert.ToChar('Z' - 'A' + 1);
				result += symbol;
			}
			return result;
		}
		private static string Decrypt(string input, int length)
		{
			string result = null;
			foreach (char c in input)
			{
				if (!char.IsLetter(c))
					continue;
				char symbol = Convert.ToChar((c - length));
				if (symbol < 'A')
					symbol += Convert.ToChar('Z' - 'A' + 1);
				else if (symbol < 'a' && symbol > 'Z')
					symbol += Convert.ToChar('z' - 'a' + 1);
				result += symbol;
			}
			return result;
		}
		public static void Run()
		{
			Console.Write("Enter a sentence: ");
			string input = Console.ReadLine();

			string encrypted = Encrypt(input, 3);
			Console.WriteLine("Encrypted sentense: " + encrypted);
			Console.WriteLine("Decrypted sentense: " + Decrypt(encrypted, 3));
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			//Task1.Run();
			//Task2.Run();
			//Task3.Run();
		}
	}
}