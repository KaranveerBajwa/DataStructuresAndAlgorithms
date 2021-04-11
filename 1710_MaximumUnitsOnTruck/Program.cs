using System;
using System.Linq;
namespace _1710_MaximumUnitsOnTruck
{
	class Program
	{
		static void Main(string[] args)
		{
			int[][] nums = new int[4][];
			nums[0] = new int[] { 5, 10 };
			nums[1] = new int[] { 2, 5 };
			nums[2] = new int[] { 4, 7 };
			nums[3] = new int[] { 3, 9 };

			//[5,10],[2,5],[4,7],[3,9]

			var res = MaximumUnits(nums, 10);

			//	int[,] sortedByFirstElement = array.OrderBy(x => x[0]);
			//		, { 2, 2 }, { 3, 1 } };
			Console.WriteLine("Hello World!");
		}

		public static int MaximumUnits(int[][] boxTypes, int truckSize)
		{
			if (boxTypes == null || boxTypes.Length == 0 || boxTypes[0] == null || boxTypes[0].Length == 0)
				return 0;
			int sum = 0;
			foreach (var box in boxTypes.OrderByDescending(x => x[1]).ToArray())
			{
				if (truckSize >= box[0])
					sum += box[0] * box[1];
				else
					sum += truckSize * box[1];
				truckSize = truckSize - box[0];
				if (truckSize < 0)
					break;
			}

			return sum;
		}
	}
}
