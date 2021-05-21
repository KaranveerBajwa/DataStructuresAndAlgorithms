using System;

namespace MaximumConsecutive1s
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Max1s(new int[]  { 1,0,1,1,1,1,0,1,1}));
      Console.WriteLine(Max1s(new int[] { 1, 0,0,0,0,0,0 }));
      Console.WriteLine(Max1s(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
      Console.WriteLine(Max1s(new int[] { 0,0,0,0,0 }));
      Console.WriteLine("What a wonderful World!");
    }

    static int Max1s(int[] arr)
    {
      bool flag = false;
      int max = 0;
      int count = 0;
      for (int i = 0; i < arr.Length; i++)
      {
        if (arr[i] == 0)
        {
          count = 0;
        }
        else
        {
          count++;
          max = Math.Max(max, count);
        }
      }
      return max;
    }
  }
}
