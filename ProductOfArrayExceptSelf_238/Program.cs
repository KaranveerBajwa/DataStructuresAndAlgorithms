using System;

namespace ProductOfArrayExceptSelf_238
{
  class Program
  {
    /*
     * Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

      The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
     https://leetcode.com/problems/product-of-array-except-self/
     */
    static void Main(string[] args)
    {
      int[] nums = { 1, 2, 3, 4 };
      Console.WriteLine(String.Join(",", ProductExceptSelf(nums)));

      int[] nums1 = { -1, 1, 0, -3, 3 };
      Console.WriteLine(String.Join(",",  ProductExceptSelf(nums1)));

      int[] nums2 = { 5};
      Console.WriteLine(String.Join(",", ProductExceptSelf(nums2)));

      Console.WriteLine("What a wonderful World!");
    }

    static int[] ProductExceptSelf(int[] nums)
    {
      if (nums == null || nums.Length == 0)
        return nums;

      int[] prefix = new int[nums.Length];
      int[] suffix = new int[nums.Length];
      int[] result = new int[nums.Length];

      prefix[0] = 1;
      suffix[suffix.Length - 1] = 1;

      for (int i = 1; i < nums.Length; i++)
      {
        prefix[i] = prefix[i - 1] * nums[i - 1];
      }

      for (int i = nums.Length - 2; i >= 0; i--)
      {
        suffix[i] = suffix[i + 1] * nums[i + 1];
      }

      for (int i = 0; i < nums.Length; i++)
      {
        result[i] = prefix[i] * suffix[i];
      }

      return result;

    }


    static int[] ProductExceptSelfAlter(int[] nums)
    {
      if (nums == null || nums.Length == 0)
        return nums;

      int[] prefix = new int[nums.Length];
      int[] suffix = new int[nums.Length];
      int[] result = new int[nums.Length];

      prefix[0] = 1;

      for (int i = 1; i < nums.Length; i++)
      {
        prefix[i] = prefix[i - 1] * nums[i - 1];
      }

      int product = 1;
      for (int i = nums.Length - 1; i >= 0; i--)
      {
        result[i] = product * prefix[i];
        product *= nums[i];
      }


      return result;

    }

  }
}
