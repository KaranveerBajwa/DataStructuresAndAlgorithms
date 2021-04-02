using System;
using System.Collections.Generic;

namespace ConsecutiveNumberSum_829
{
  // leet code probelm: https://leetcode.com/problems/consecutive-numbers-sum/
  class Program
  {
    static void Main(string[] args)
    {

      //Console.WriteLine(CountConsecutiveNumberSum(15));
      //Console.WriteLine(CountConsecutiveNumberSum(5));
      //Console.WriteLine(CountConsecutiveNumberSum(9));
      //Console.WriteLine(CountConsecutiveNumberSum(1));
      //Console.WriteLine(CountConsecutiveNumberSum(2));
      //Console.WriteLine(CountConsecutiveNumberSum(3));
      Console.WriteLine(CountConsecutiveNumberSum(77601076));
      Console.WriteLine("Hello World!");
    }

    static int CountConsecutiveNumberSum(int n)
    {
      int end = n / 2 + 1;
      int right = 1;
      int sum = 1;
      Queue<int> queue = new Queue<int>();
      queue.Enqueue(1);
      int count = 0;

      while (right <= end)
      {
        if (sum > n)
        {
          sum -= queue.Dequeue();
        }
        else if (sum < n)
        {
          right = right + 1;
          queue.Enqueue(right);
          sum += right;
        }
        else
        {
          count++;
          sum -= queue.Dequeue();
        }
      }

      return n > 2 ? count+1: count;
    }
  }
}
