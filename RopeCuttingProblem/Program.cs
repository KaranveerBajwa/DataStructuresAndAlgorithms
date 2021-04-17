using System;

namespace RopeCuttingProblem
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Partition(1,2,5,1));


      Console.WriteLine("What a wonderful World!");
    }

    static int Partition(int n, int a, int b, int c)
    {
      if (n == 0)
        return 0;
      if (n < 0)
        return -1;

      int res = Math.Max(Partition(n - a, a, b, c),
                Math.Max(Partition(n - b, a, b, b),
                Partition(n - c, a, b, c)
                ));

      if (res == -1)
        return -1;

      return res + 1;
    
    }

  }
}
