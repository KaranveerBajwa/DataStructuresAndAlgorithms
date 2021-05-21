using System;

namespace SearchInRowWiseAndColumnWiseSortedMatrix
{
  class Program
  {
    static void Main(string[] args)
    {
      int[,] grid = {
      { 10, 20, 30, 40 },
      { 15, 25, 35, 45 },
      { 27, 29, 37, 48},
      { 32, 33, 39, 50}
      };

      Search(grid, 60);
      Search(grid, 50);
    }

    static void Search(int[,] matrix, int target)
    {
      // start with last element in first row
      // do it till col >= 0 and row < rowCount (in matrix bounds)
      // if target is equal to that element print and return
      // if target is less , move to left column
      // else move to row down
      int rows = matrix.GetLength(0);
      int cols = matrix.GetLength(1);
      int row = 0;
      int col = cols - 1;
      while (col >= 0 && row < rows)
      {
        if (matrix[row, col] == target)
        {
          Console.WriteLine($"Found it at location{row}, {col}");
          return;
        }
        else if (matrix[row, col] > target)
          col = col - 1;
        else
          row++;
      }
      Console.WriteLine($"Cannot find {target}");
    }
  }
}