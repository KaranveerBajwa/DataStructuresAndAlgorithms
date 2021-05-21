using System;

namespace PrintMatrixInSnakePattern
{
  class Program
  {
    static void Main(string[] args)
    {
      int[,] matrix = {
        { 1,2,3,4},
        { 5,6,7,8},
        { 9,10,11,12},
        { 13,14,15,16}
      };

      PrintMatrix(matrix);
      Console.WriteLine("What a wonderful World!");
    }

    static void PrintMatrix(int[,] matrix)
    {
      int rows = matrix.GetLength(0);
      int cols = matrix.GetLength(1);

      for (int i = 0; i < rows; i++)
      {
        if (i % 2 == 0)
        {
          for (int j = 0; j < cols; j++)
          {
            Console.Write(matrix[i,j] + " ");
          }
        }
        else {
          for (int j = cols - 1; j >= 0; j--)
          {
            Console.Write(matrix[i, j] + " ");
          }
        }      
      }
      Console.WriteLine();
    }
  }
}
