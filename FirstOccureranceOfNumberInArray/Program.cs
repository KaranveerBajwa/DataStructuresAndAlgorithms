using System;

namespace FirstOccureranceOfNumberInArray
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] nums = { 2, 3, 4, 1, 3 };
      Console.WriteLine(FindFirstOccuranceIndex(nums, 3));

      Console.WriteLine("What a wonderful World!");
    }

    static int FindFirstOccuranceIndex(int[] nums, int target)
    {
      return FindFirstOccuranceIndexHelper(nums, target, 0);
    }

    static int FindFirstOccuranceIndexHelper(int[] nums, int target, int curIndex)
    {
      if (curIndex == nums.Length )
        return -1;

      if (nums[curIndex] == target)
        return curIndex;

      return FindFirstOccuranceIndexHelper(nums, target, curIndex + 1);

    }
  }
}
