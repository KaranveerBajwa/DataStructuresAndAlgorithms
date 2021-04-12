using System;

namespace MazePathExists
{
  class Program
  {
    static void Main(string[] args)
    {
      int[,] matrix = {
        { 0,1,1,1 },
        { 0,0,0,1},
        { 1,0,1,1},
        { 1,1,0,0}
      };

      Console.WriteLine($"Path Exists: {PathExists(matrix)}");
      Console.WriteLine("Hello World!");
    }

    // input matrix[n,m]
    // output bool pathexists

    // helper function
    // input matrix, row, col, visited[n,m] matrix the size of input
    // out bool

    static bool PathExists(int[,] matrix)
    {
      bool[,] visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];
      return PathExistsHelper(matrix, 0,0, visited);
    }


    static bool PathExistsHelper(int[,] matrix, int row, int col, bool[,] visited)
    {
      if (OutOfBound(row, col, matrix) || matrix[row, col] == 1)
        return false;

      if ((row == matrix.GetLength(0) - 1 || col == matrix.GetLength(1) - 1))
        return true;

      if (visited[row, col])
        return false;

      visited[row, col] = true;

      Point[] points = { new Point(row, col - 1), new Point(row, col + 1), new Point(row - 1, col), new Point(row + 1, col) };
      foreach (Point point in points)
      {
        if (PathExistsHelper(matrix, point.Row, point.Col, visited))
        {
          return true;
        }
      }
      return false;
    }

    static bool OutOfBound(int row, int col, int[,] matrix)
    {
      return (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1));
    }
  
  }

  public class Point
  {
    public int Row { get; set; }
    public int Col { get; set; }

    public Point(int row, int col)
    {
      Row = row;
      Col = col;
    }
  }


}
