using System;

namespace MaximumDifference
{
  //Maximum Difference problem is to find the maximum of arr[j] - arr[i] where j>i.
  class Program
  {
    static void Main(string[] args)
    {
      //int[] nums = { 2, 3, 10, 6, 4, 8, 1 };
      int[] nums = { 0,0,0,0};
      Console.WriteLine(MaxDifference(nums));
      Console.WriteLine("What a wonderful World!");
    }

    static int MaxDifference(int[] nums)
    {
      if (nums == null || nums.Length <= 1)
        return -1;
      int minVal = nums[0];
      int res = nums[1] - nums[0];

      for (int i = 1; i < nums.Length; i++)
      {
        res = Math.Max(res, nums[i] - minVal);
        minVal = Math.Min(minVal, nums[i]);
      }
      return res;
    }
  }
}
