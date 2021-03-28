using System;
using System.Security.Principal;

namespace ClimbStairs
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      Console.WriteLine(ClimbStairs(0, 5));
      Console.WriteLine(ClimbStairsDP(5));

    }

    static int ClimbStairs(int step, int dest)
    {
      if (step > dest)
        return 0;

      if (step == dest)
        return 1;

      return ClimbStairs(step + 1, dest) + ClimbStairs(2 + step, dest);
    }

    // to get to 0 step you do have to take any step 0 step
    static int ClimbStairsDP(int destination)
    {
      int[] steps = new int[destination + 1];
      steps[0] = 0;
      steps[1] = 1;
      steps[2] = 2;

      for (int i = 3; i < steps.Length; i++)
      {
        steps[i] = steps[i - 1] + steps[i - 2];
      }

      return steps[steps.Length - 1];
    }
  }
}
