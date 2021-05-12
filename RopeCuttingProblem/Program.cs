using System;

namespace RopeCuttingProblem
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Partition(1,2,5,1));
      Console.WriteLine(Partition(5,11,9,12));

      Console.WriteLine("What a wonderful World!");
    }

    /*
    // return -1 if the partition is not possible
    // we explicitly check for result that it is not -1 to avoid incorrect result
    // if we directly add 1 to the Math.Max statement and return then when there are no partition possible
    // Math.Max will get -1 and we add 1 and it will return 0, which is not correct so we add 1 only of the result is not -1
    */
    static int Partition(int n, int a, int b, int c)
    {
      if (n == 0)
        return 0;
      if (n < 0)
        return -1;
    
     int res =
        Math.Max(Partition(n - a, a, b, c),
                Math.Max(Partition(n - b, a, b, b),
                Partition(n - c, a, b, c)
                )) ;

      if (res == -1)
        return -1;

      return res + 1;

    }

  }
}
