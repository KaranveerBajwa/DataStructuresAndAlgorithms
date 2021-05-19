using System;

namespace LeadersInArray
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] nums = { 7, 10, 4, 3, 6, 5, 2 };
      PrintLeader(nums);
      Console.WriteLine("What a wonderful World!");
    }

    static void PrintLeader(int[] nums)
    {
      int curLeader = nums[nums.Length - 1];
      Console.Write(curLeader + " ");

      for (int i = nums.Length - 2; i >= 0; i--)
      {
        if (curLeader < nums[i])
        {
          curLeader = nums[i];
          Console.Write(curLeader + " ");
        }      
      }
    
    }

  }
}
