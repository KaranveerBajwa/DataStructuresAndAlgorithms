using System;

namespace BinaryPathTreeSum
{
  class Program
  {
    /*
     * Given a binary tree and a number ‘S’, find if the tree has a path from root-to-leaf such that the sum of all the node values of that path equals ‘S’.
     */
    static void Main(string[] args)
    {
      TreeNode root = new TreeNode(12);
      root.Left = new TreeNode(7);
      root.Right = new TreeNode(1);
      root.Left.Left = new TreeNode(9);
      root.Right.Left = new TreeNode(10);
      root.Right.Right = new TreeNode(5);
      Console.WriteLine("Tree has path: " + HasPath(root, 23));
      Console.WriteLine("Tree has path: " + HasPath(root, 16));

      Console.WriteLine("Hello World!");
    }



      public static bool HasPath(TreeNode root, int sum)
      {
        return HasPathHelper(root, sum, 0);
      }

    static bool HasPathHelper(TreeNode node, int sum, int currentSum)
    {
      if (node == null)
        return false;
      Console.WriteLine($"HasPathHelper(Node: {node.Value}, sum: {sum}, currentSum: {currentSum} )");

      int curSum = currentSum + node.Value;

      if (node.Left == null && node.Right == null && curSum == sum)
        return true;

      return HasPathHelper(node.Left, sum, curSum) || HasPathHelper(node.Right, sum, curSum);

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
