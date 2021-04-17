using System;

namespace MinimumDifficultyOfJobSchedule_1335
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] nums = { 10, 20, 60, 50, 30, 40 };
      int[] min = { Int32.MaxValue };
      Console.WriteLine(partition(nums, nums.Length, 3));
      Console.WriteLine("What a wonderfule World!");
    }


      // for n boards and k partitions
      static int partition(int[] arr, int n, int k)
      {

      Console.WriteLine($"partition({n}, {k})");
        // base cases
        if (k == 1) // one partition
          return sum(arr, 0, n - 1);

        if (n == 1) // one board
          return arr[0];

        int best = int.MaxValue;

      // find minimum of all possible maximum
      // k-1 partitions to the left of arr[i],
      // with i elements, put k-1 th divider
      // between arr[i-1] & arr[i] to get k-th
      // partition
      for (int i = 1; i <= n; i++)
      {
        Console.WriteLine($"Best is : {best}");
        best = Math.Min(best, Math.Max(partition(arr, i, k - 1),
                                           sum(arr, i, n - 1)));
      }
        return best;
      }

      // function to calculate sum
      // between two indices in array
      static int sum(int[] arr, int from, int to)
      {
        int total = 0;
        for (int i = from; i <= to; i++)
          total += arr[i];
        return total;
      }

    }
  }

