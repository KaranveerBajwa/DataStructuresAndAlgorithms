using System;

namespace FindSumOfAllPathsWith_0_to_9
{
  class Program
  {/*
    * Given a binary tree where each node can only have a digit (0-9) value, each root-to-leaf path will represent a number. Find the total sum of all the numbers represented by all paths.

Example 1:
        2
    3       9

  4   6   8    5
                  3

Sum should be 234 + 236 + 298 + 2953 = 3721
    */
    static void Main(string[] args)
    {
      TreeNode root = new TreeNode(2);
      root.Left = new TreeNode(3);
      root.Right = new TreeNode(9);
      root.Left.Left = new TreeNode(4);
      root.Left.Right = new TreeNode(6);
      root.Right.Left = new TreeNode(8);
      root.Right.Right = new TreeNode(5);
      root.Right.Right.Right = new TreeNode(3);
      Console.WriteLine(SumOfAllPaths(root));

      TreeNode root1 = new TreeNode(9);
      root1.Left = new TreeNode(7);
      root1.Right = new TreeNode(1);
      root1.Left.Left = new TreeNode(4);
      root1.Right.Left = new TreeNode(9);
      root1.Right.Right = new TreeNode(5);
      Console.WriteLine(SumOfAllPaths(root1));
      
      Console.WriteLine("Hello World!");
    }

    static int SumOfAllPaths(TreeNode root)
    {
      int[] totalSum = { 0 };
      SumOfAllPathsHelper(root, 0, totalSum);
      return totalSum[0];
    }

    static void SumOfAllPathsHelper(TreeNode node, int sum, int[] totalSum)
    {
      if (node == null)
        return;

      int curSum = 10 * sum + node.Value;
      if (node.Left == null && node.Right == null)
        totalSum[0] = totalSum[0] + curSum;
      SumOfAllPathsHelper(node.Left, curSum, totalSum);
      SumOfAllPathsHelper(node.Right, curSum, totalSum);
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
