using System;
using System.Collections.Generic;

namespace CoinChangingProblem
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] nums = { 1, 2, 3 };
      int sum = 4;
      Console.WriteLine(CountCombinations(nums, sum));
      Console.WriteLine(CountCombinationTabulation(nums, sum));
      Console.WriteLine("What a wonderful  World!");
    }


    static int CountCombinations(int[] nums, int target)
    {
      List<int> combination = new List<int>();
      return CountCombinationsHelper(nums, target, 0, combination);
    }

    static int CountCombinationsHelper(int[] nums, int target, int index, List<int> combination)
    {
      Console.WriteLine($"CountCombinationsHelper({target}, {index}, {String.Join(",", combination)})");
      if (target == 0)
      {
        Console.WriteLine(String.Join(",", combination));
        return 1;
      }

      if (target < 0)
        return 0;

      int res = 0;

      for (int i = index; i < nums.Length; i++)
      {
        int sum = target - nums[i];
        combination.Add(nums[i]);
        res = res + CountCombinationsHelper(nums, sum, i, combination);
        combination.RemoveAt(combination.Count - 1);
      }
      return res;
    }

    static int CountCombinationTabulation(int[] nums, int sum)
    {
      int[,] dp = new int[sum + 1, nums.Length + 1];
      int rowCount = dp.GetLength(0);
      int colCount = dp.GetLength(1);

      for (int i = 0; i < colCount; i++)
      {
        dp[0, i] = 1; // for a 0 sum , there is one way to make sum 0 with 0 coins
      }

      for (int j = 1; j < rowCount; j++)
      {
        dp[j, 0] = 0; // if you have no coins bur the sum is greater than 0
      }

      for (int i = 1; i < rowCount; i++)
        for (int j = 1; j < colCount; j++)
        {
          dp[i, j] = dp[i, j - 1]; // ignore the jth coin
          if (nums[j - 1] <= i)          // if the value of jth coin is smaller or e
            dp[i, j] += dp[i - nums[j - 1], j];
        }
      return dp[rowCount-1, colCount-1];
    }



  }
}
