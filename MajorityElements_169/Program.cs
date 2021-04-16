using System;

namespace MajorityElements_169
{
  class Program
  {
    /*
     * Given an array nums of size n, return the majority element.

        The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.
     * https://leetcode.com/problems/majority-element/
     */
    static void Main(string[] args)
    {
      int[] nums = { 2,2,2,1,1 };
      Console.WriteLine(MajorityElement(nums));
      Console.WriteLine("Hello World!");
    }

    static int MajorityElement(int[] nums)
    {
      if (nums == null || nums.Length == 0)
        throw new ArgumentNullException("Input cannot be null");

      int candidate = nums[0];
      int count = 1;

      for (int i = 1; i < nums.Length; i++)
      {
        if (count > 0)
        {
          if (candidate == nums[i])
            count++;
          else
            count--;
        }
        else
        {
          candidate = nums[i];
          count = 1;
        }
      }

      count = 0;
      for (int i = 0; i < nums.Length; i++)
      {
        if (candidate == nums[i])
          count++;
      }

      if (count > nums.Length / 2)
        return candidate;
      else
        return -1;
    }
  }
}
