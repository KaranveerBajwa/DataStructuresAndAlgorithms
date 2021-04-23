using System;

namespace _01Knapsack
{
  class Program
  {
    /*
     * give the weight and value of items what is maximum value you can take if you have knapscak that can cary certain weight
     * Budget tasks and tasks cost  and value, pick up the task that give you maximum value
     * exam  questions and their time and the remainder time that you have , how to get maximu score no partial score
      Time complexity is 2 raised Power n as at every stage we are considering two possibilities inclucde current or not include current
     */ 
    static void Main(string[] args)
    {
      int[] values = { 10,40, 30, 50};
      int[] weights = {5,4,6,3 };
      int ksWeight = 10;
      Console.WriteLine(MaxRobValue(weights, values, ksWeight));

      Console.WriteLine("Waht a wonderful World!");
    }

    static int MaxRobValue(int[] weights, int[] values, int ksWeight)
    {
      return MaxRobValueHelper(weights, values, ksWeight, 0);    
    }

    static int MaxRobValueHelper(int[] weights, int[] values, int ksWeight, int curIndex)
    {
      if (ksWeight == 0 || curIndex >= weights.Length)
        return 0;

      if (weights[curIndex] > ksWeight)
        return MaxRobValueHelper(weights, values, ksWeight, curIndex + 1);
      else
      {

        return Math.Max(
          MaxRobValueHelper(weights, values, ksWeight, curIndex + 1)
          , values[curIndex] + MaxRobValueHelper(weights, values, ksWeight - weights[curIndex], curIndex + 1)
          ); ;
      }    
    
    }
  }
}
