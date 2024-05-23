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
	internal class Program
	{
		static void Main(string[] args)
		{
			Task1.Run();

		}
	}
}