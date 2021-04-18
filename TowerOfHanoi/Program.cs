using System;

namespace TowerOfHanoi
{
  class Program
  {
    static void Main(string[] args)
    {
      TOH(1, 'A', 'B', 'C');
      TOH(2, 'A', 'B', 'C');
      Console.WriteLine();

      Console.WriteLine("What a wonderful World!");
      Console.WriteLine();
      
      TOH(3, 'A', 'B', 'C');

    }

    static void TOH(int n, char a, char b, char c)
    {
      if (n == 0)
        return;

      TOH(n - 1, 'A', 'C', 'B');
      Console.WriteLine($"Move {n} disk from {a} to {c}");
      TOH(n - 1, 'B', 'A', 'C');


    }
  }
}
