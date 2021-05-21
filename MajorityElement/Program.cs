using System;

namespace MajorityElement
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(MajorityElementIndex(new int[] {3,1,2,3,3,4,3 }));
      Console.WriteLine(MajorityElementIndex(new int[] {6,8,4,8,8 }));
      Console.WriteLine(MajorityElementIndex(new int[] { 0,0,0,0,0,0 }));
      Console.WriteLine(MajorityElementIndex(new int[] { 8,3,4,8,8 }));
      Console.WriteLine(MajorityElementIndex(new int[] { 20,30,40,50,50,50,50,50}));
      Console.WriteLine(MajorityElementIndex(new int[] { 3,7,4,7,7,5}));
      Console.WriteLine("What a wonderful World!");
    }

    static int MajorityElementIndex(int[] nums)
    {
      int res = 0;
      int count = 1;
      for (int i = 1; i < nums.Length; i++)
      {
        if(count ==0)
        {
          res = i;
          count = 1;
        }
        else if (nums[i] == nums[res])
        {
          count++;
        }
        else if (count > 0)
        {
          count--;
        }


      }
      int candidate = nums[res];
      count = 0;
      for (int i = 0; i < nums.Length; i++)
      {
        if (nums[i] == candidate)
          count++;      
      }
      if (count > nums.Length / 2)
        return res;
      else return -1;


    }
  }
}
