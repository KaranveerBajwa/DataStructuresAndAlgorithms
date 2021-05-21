using System;

namespace TransposeOfMatrix
{
  class Program
  {
    static void Main(string[] args)
    {
      int[,] matrix = {
      { 1,2,3,4},
      {5,6,7,8 },
      { 9, 10, 11,12},
      { 13,14,15,16}
      };
      Transpose(matrix);
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        for (int j = 0; j < matrix.GetLength(1); j++)
          Console.Write(matrix[i, j]);
        Console.WriteLine();
        }
          Console.WriteLine("What a wonderful World!");
    }

    static void Transpose(int[,] matrix)
    {
      for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = i+1; j < matrix.GetLength(1); j++)
          Swap(matrix, i, j);          
    }

    static void Swap(int[,] matrix, int i, int j)
    {
      int temp = matrix[i, j];
      matrix[i, j] = matrix[j, i];
      matrix[j, i] = temp; 
    }
  }
}
