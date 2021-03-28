using System;
using System.Collections.Generic;

namespace FindSmallestCommonElementInAllRowsInMatrix
{
  /*
   * Given an m x n matrix mat where every row is sorted in strictly increasing order, return the smallest common element in all rows.
If there is no common element, return -1.

Example 1:
Input: mat = [[1,2,3,4,12],[2,4,5,8,10],[3,5,7,9,11],[1,3,5,7,9]]
Output: 5

Example 2:
Input: mat = [[1,2,3],[2,3,4],[2,3,5]]
Output: 2

Constraints:
m == mat.length
n == mat[i].length
1 <= m, n <= 500
1 <= mat[i][j] <= 104
mat[i] is sorted in strictly increasing order.
 */
  class Program
  {
    static void Main(string[] args)
    {
      int[,] matrix = { { 1, 2, 3, 4, 5 }, { 3, 4, 6, 8, 10 }, { 4, 5, 7, 9, 11 }, { 1, 3, 5, 7, 9 } };
      Console.WriteLine(SmallestElement(matrix));

      int[,] matrix2 = { { 1, 2, 3 }, { 2, 3, 4 }, { 2, 3, 5 } };
      Console.WriteLine(SmallestElement(matrix2));
      Console.WriteLine("Hello World!");
      int[][] matrix3 = new int[4][];
      matrix3[0] = new int[] { 1, 2, 3, 4, 5 };
      matrix3[1] = new int[] { 3, 4, 6, 8, 10 };
      matrix3[2] = new int[] { 4, 5, 7, 9, 11 };
      matrix3[3] = new int[] { 1, 3, 5, 7, 9 } ;
      Console.WriteLine(SmallestElement2(matrix3));
//      Console.WriteLine(SmallestElement2(matrix2));

    }

    static int SmallestElement(int[,] mat)
    {
      Dictionary<int, int> trackCount = new Dictionary<int, int>();
      int rowCount = mat.GetLength(0);
      int colCount = mat.GetLength(1);
      for (int col = 0; col < colCount; col++)
      {
        trackCount.Add(mat[0, col], 1);
      }

      for (int row = 1; row < rowCount; row++)
      {
        for (int col = 0; col < colCount; col++)
        {
          if (trackCount.ContainsKey(mat[row, col]))
          {
            trackCount[mat[row, col]]++;
          }
        }
      }

      int minVal = Int32.MaxValue;
      foreach (var entry in trackCount)
      {
        if (entry.Value == rowCount && entry.Key < minVal)
          minVal = entry.Key;
      }

      return minVal == Int32.MaxValue ? -1 : minVal;
    }

    static int SmallestElement2(int[][] mat)
    {
      if (mat == null || mat.Length == 0 || mat[0].Length == 0)
        return -1;
      int minValue = Int32.MaxValue;
      int rowCount = mat.Length;
      int colCount = mat[0].Length;

      Dictionary<int, int> trackCount = new Dictionary<int, int>();
      for (int col = 0; col < colCount; col++)
      {
        trackCount.Add(mat[0][col], 1);
      }

      for (int row = 1; row < rowCount; row++)
      {
        for (int col = 0; col < colCount; col++)
        {
          if (trackCount.ContainsKey(mat[row][col]))
          {
             //trackCount[mat[row][col]++; change to check the count within the loop to  improve on time
            if (++trackCount[mat[row][col]] == rowCount)
              return mat[row][col];            
          }
        }
      }
      /* we do not have to do this any more as we check for the element right in the loop
      foreach (var entry in trackCount)
      {
        if (entry.Value == rowCount && entry.Key < minValue)
          minValue = entry.Key;
      }

      if (minValue == Int32.MaxValue)
        return -1;
      else 
        return minValue;
      */

      return -1;
    }
  }
}
