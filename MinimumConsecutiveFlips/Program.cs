using System;

namespace MinimumConsecutiveFlips
{
  //Given a binary array, we need to find the minimum of number of group flips to make all array elements same.  In a group flip, we can flip any set of consecutive 1s or 0s.

  class Program
  {
    static void Main(string[] args)
    {
      bool[] arr = { false, true, true, true,false, true, true, true, false };
      Console.WriteLine(ConsecutiveFlips(arr));
      Console.WriteLine("What a wonderful World!");
    }

    static int ConsecutiveFlips(bool[] arr)
    {
      int count = 0;
      for (int i = 1; i < arr.Length; i++)
      {
        if (arr[i] != arr[i - 1])
        {
          if (arr[i] != arr[0])
          {
            Console.Write($"From {i} ");
            count++;
          }
          else
            Console.Write($"To {i}.");        
        }
      }

      if (arr[arr.Length - 1] != arr[0])
        Console.Write($"To {arr.Length - 1}.");
      Console.WriteLine();
      return count;
    }
  }
}
