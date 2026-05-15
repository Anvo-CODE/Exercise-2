using System;

public class Class1

    static void Main2(string[] args)
{
	static int max;
	static int sum(params int[] nums)
	{
		int sum = 0;
		foreache(int num in nums)
		{
			sum += num;
		}
		return sum;
		{
			int x = sum(1, 2, 3, 4, 5);
			int y = sum(1);
			int z = sum(1, 2, 3, 4, 5, 6, 7, 8);
			Console.WriteLine("so lon nhat la: " + max);
		}
	}
}
