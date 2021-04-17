using System;

namespace ReplaceNegativeWithZero
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] nums = { -1, 2, -3,  4 };
      ReplaceNegativeWithZeroes(nums);

      Console.WriteLine("What a wonderful World!");
    }

    static void ReplaceNegativeWithZeroes(int[] nums)
    {
      ReplaceNegativeWithZeroesHelper(nums, 0);
    }

    static void ReplaceNegativeWithZeroesHelper(int[] nums, int curIndex)
    {
      if (curIndex == nums.Length)
        return;

      if (nums[curIndex] < 0)
        nums[curIndex] = 0;

      ReplaceNegativeWithZeroesHelper(nums, curIndex + 1);
    }


  }

}
