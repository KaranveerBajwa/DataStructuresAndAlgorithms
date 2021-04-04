using System;
using System.Collections.Generic;

namespace AllPathsForSum
{
	class Program
	{
		/*
		 Given a binary tree and a number ‘S’, find all paths from root-to-leaf such that the sum of all the node values of each path equals ‘S’.
		Sum: 12 Output: [[1, 7, 4], [1, 9, 2]]Explanation: Here are the two paths with sum '12':1 -> 7 -> 4 and 1 -> 9 -> 2
		 */
		static void Main(string[] args)
		{
        TreeNode root = new TreeNode(1);
        root.Left = new TreeNode(7);
        root.Right = new TreeNode(9);
        root.Left.Left = new TreeNode(4);
        root.Left.Right = new TreeNode(5);
        root.Right.Left = new TreeNode(2);
        root.Right.Right = new TreeNode(7);
        List<List<int>> result = FindAllPaths(root, 12);


      TreeNode root1 = new TreeNode(12);
      root1.Left = new TreeNode(7);
      root1.Right = new TreeNode(1);
      root1.Left.Left = new TreeNode(4);
      root1.Right.Left = new TreeNode(10);
      root1.Right.Right = new TreeNode(5);
      List<List<int>> result1 = FindAllPaths(root1, 23);
      Console.WriteLine("Hello World!");
      }

      static List<List<int>> FindAllPaths(TreeNode root, int sum)
      {
        List<List<int>> paths = new List<List<int>>();
        List<int> pathToSum = new List<int>();

        FindAllPathsHelper(root, sum, 0, pathToSum, paths);
        return paths;
      }

      static void FindAllPathsHelper(TreeNode node, int sum, int currentSum, List<int> pathToSum, List<List<int>> paths)
      {
        if (node == null)
          return;

        pathToSum.Add(node.Value);
        int curSum = currentSum + node.Value;
        if (node.Left == null && node.Right == null && sum == curSum)
          paths.Add(new List<int>(pathToSum));

        FindAllPathsHelper(node.Left, sum, curSum, pathToSum, paths);
        FindAllPathsHelper(node.Right, sum, curSum, pathToSum, paths);
        pathToSum.RemoveAt(pathToSum.Count - 1);

      }

    }
    public class TreeNode
    {
      public int Value;
      public TreeNode Left;
      public TreeNode Right;

      public TreeNode(int x)
      {
        Value = x;
      }
    };

  }
