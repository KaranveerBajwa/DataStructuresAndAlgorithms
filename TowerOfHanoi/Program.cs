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

    static void TOH(int n, char from, char aux, char to)
    {
      if (n == 0)
      {
      //  Console.WriteLine($"Move {n} disk from {from} to {to}");
        return;
      }

      TOH(n - 1, from, to, aux);
      Console.WriteLine($"Move {n} disk from {from} to {to}");
      TOH(n - 1, aux,from,to);


    }
  }
}
