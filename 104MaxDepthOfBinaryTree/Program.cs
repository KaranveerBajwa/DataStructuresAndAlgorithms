using System;

namespace _104MaxDepthOfBinaryTree
{
  /*
   * Given the root of a binary tree, return its maximum depth.

A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
   https://leetcode.com/problems/maximum-depth-of-binary-tree/
   */
  class Program
  {
    static void Main(string[] args)
    {
      TreeNode root = null; //= new TreeNode();
      //root.Left = new TreeNode(7);
      //root.Right = new TreeNode(9);
      //root.Left.Left = new TreeNode(4);
      //root.Left.Right = new TreeNode(5);
      //root.Right.Left = new TreeNode(2);
      //root.Right.Right = new TreeNode(7);
      Console.WriteLine(MaxDepth(root));

      Console.WriteLine("What a wonderful World!");
    }

    static int MaxDepth(TreeNode root)
    {
      if (root == null)
        return 0;
      return 1 + Math.Max(MaxDepth(root.Left), MaxDepth(root.Right));    
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
