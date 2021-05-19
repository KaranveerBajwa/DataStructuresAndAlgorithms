using System;

namespace StockBuyAndSell
{
  class Program
  {
    static void Main(string[] args)
    {
      //int[] arr = { 1, 5, 2, 1, 3, 8, 12 }; // output 15
      int[] arr = { 1, 5, 3, 8, 12 }; // 13
      Console.WriteLine(MaxProfit(arr));
      Console.WriteLine(MaxProfit(new int[] { 1,5,3,8,12})); //ouput 13
      Console.WriteLine(MaxProfit(new int[] { 30,20,10})); // output 0
      Console.WriteLine(MaxProfit(new int[] { 1,5,3,1,2,8})); // output 11
      Console.WriteLine(MaxProfit(new int[] { 10, 20, 30 })); //output 20

      Console.WriteLine("What a wonderful World!");
    }

    static int MaxProfit(int[] nums)
    {
      int profit = 0;
      for (int i = 1; i < nums.Length; i++)
      {
        if (nums[i] > nums[i - 1])
          profit += nums[i] - nums[i - 1];
      }
      return profit;
    }
  }
}
