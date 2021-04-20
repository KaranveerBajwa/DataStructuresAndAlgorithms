using System;

namespace PrefixSumOf2DArray
{
  class Program
  {
    static void Main(string[] args)
    {
      int[,] grid = {
      {10,20,30 },
      {5,10,20 },
      { 2,4,6}
      };

      var res = PrefixSum(grid);
      Console.WriteLine("What a wonderful World!");
    }

    static int[,] PrefixSum(int[,] grid)
    {
      int[,] ps = new int[grid.GetLength(0), grid.GetLength(1)];

      // if row =0 and col =0
      ps[0, 0] = grid[0, 0];
      // if row = 0
      for (int i = 1; i < grid.GetLength(1); i++)
        ps[0, i] = ps[0, i - 1] + grid[0, i];

      // if col =0

      for (int j = 1; j < grid.GetLength(0); j++)
        ps[j, 0] = ps[j - 1, 0] + grid[j, 0];

      for (int i = 1; i < grid.GetLength(0); i++)
        for (int j = 1; j < grid.GetLength(1); j++)
        {
          ps[i, j] = ps[i - 1, j] + ps[i, j - 1] - ps[i - 1, j - 1] + grid[i - 1, j - 1];    
        }
      return ps;
    }
  }
}
