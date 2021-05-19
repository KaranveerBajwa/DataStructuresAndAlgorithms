using System;

namespace FrequencyInSortedArray
{
  class Program
  {
    static void Main(string[] args)
    {
      PrintFrequencies(new int[] { 10, 10,10,10,10 });
      Console.WriteLine("What a wonderful World!");
    }

    static void PrintFrequencies(int[] nums)
    {
      if (nums == null || nums.Length == 0)
        return;
      int cur = nums[0];
      int count = 1;
      for (int i = 1; i < nums.Length; i++)
      {
        if (nums[i] != cur)
        {
          Console.WriteLine(cur + " " + count);
          cur = nums[i];
          count = 1;
        }
        else
          count++;
      }
      Console.WriteLine(cur + " " + count);

    }
  }
}
