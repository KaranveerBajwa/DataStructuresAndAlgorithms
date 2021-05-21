using System;
using System.Collections.Generic;

namespace PairWithGivenSumInUnsortedArray
{
  class Program
  {
    static void Main(string[] args)
    {
      var res = PairWithSum(new int[] { 3,2,8,15,-8}, 17);
      Console.WriteLine(res.Item1 + ", " + res.Item2);
      var res1 = PairWithSum(new int[] { 2, 1, 6, 3 }, 6);
      
      var res2 = PairWithSum(new int[] { 5, 8, -3, 6 }, 3);
      Console.WriteLine(res2.Item1 + " , " + res2.Item2);

      Console.WriteLine();
      Console.WriteLine("What a wonderful World!");
    }

    static Tuple<int,int> PairWithSum(int[] nums, int sum)
    {
      Dictionary<int, int> dict = new Dictionary<int, int>();
      for (int i = 0; i < nums.Length; i++)
      {
        if (dict.ContainsKey(nums[i]))
        {
          return new Tuple<int,int>(i, dict[nums[i]]);
        }
        else
          dict.Add(sum - nums[i], i);
      }
      return null;
    
    }
  }
}
