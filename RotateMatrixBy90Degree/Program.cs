using System;

namespace RotateMatrixBy90Degree
{
  class Program
  {
    static void Main(string[] args)
    {
      int[,] matrix = {
      {1,2,3,4 },
      { 5,6,7,8},
      { 9,10,11,12},
      { 13,14,15,16}
      };
      Rotate(matrix);
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        for (int j = 0; j < matrix.GetLength(1); j++)
          Console.Write(matrix[i,j] + " ");
        Console.WriteLine();
      }
      Console.WriteLine("What a wonderful World!");
    }


    static void Rotate(int[,] matrix)
    {
      TransposeMatrix(matrix);
      ReverseIndividualColumns(matrix);  
    
    }

    // for matrix transpose 
    // i = 0 to rows
    // j = 1+1 to cols
    //swap(matrix[i,j] matrix[j,i])

    static void TransposeMatrix(int[,] matrix)
    {
      for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = i + 1; j < matrix.GetLength(1); j++)
          Swap(matrix, i, j);
    }

    static void ReverseIndividualColumns(int[,] matrix)
    {
      for (int i = 0; i < matrix.GetLength(1); i++)
      {
        int low = 0;
        int high = matrix.GetLength(1) - 1;
        while (low < high)
        {
          Swap(matrix, low, high, i);
          low++;
          high--;
        }      
      }
    }


    static void Swap(int[,] matrix, int i, int j)
    {
      int temp = matrix[i, j];
      matrix[i, j] = matrix[j, i];
      matrix[j, i] = temp;
    
    }

    static void Swap(int[,] matrix, int low, int high, int col)
    {
      int temp = matrix[low, col];
      matrix[low, col] = matrix[high, col];
      matrix[high, col] = temp;
    }


  }
}
