using System;

namespace CountNumberOfOccranceInArray
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] nums = { 3, 3, 4, 1, 7, 8  };
      Console.WriteLine(CountOccurances(nums, 3));
      Console.WriteLine("What a wonderful World!");
    }


    static int CountOccurances(int[] nums, int target)
    {
      return CountOccuranceHelper(nums, target, 0);
    }

    static int CountOccuranceHelper(int[] nums, int target, int curIndex)
    {
      if (curIndex == nums.Length)
        return 0;
 
      if (nums[curIndex] == target)
        return 1 + CountOccuranceHelper(nums, target, curIndex + 1);
      else
        return CountOccuranceHelper(nums, target, curIndex + 1);
    
    }
  }
}
