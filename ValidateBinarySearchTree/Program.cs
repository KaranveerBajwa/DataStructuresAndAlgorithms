using System;

namespace ValidateBinarySearchTree
{
  class Program
  {
    /*
     * Given the root of a binary tree, determine if it is a valid binary search tree (BST).

A valid BST is defined as follows:

The left subtree of a node contains only nodes with keys less than the node's key.
The right subtree of a node contains only nodes with keys greater than the node's key.
Both the left and right subtrees must also be binary search trees.
    https://leetcode.com/problems/validate-binary-search-tree/
     */
    static void Main(string[] args)
    {
      TreeNode root = null; // new TreeNode(11);
      //root.Left = new TreeNode(9);
      //root.Left.Left = new TreeNode(4);
      //root.Left.Right = new TreeNode(10);
      Console.WriteLine(IsBst(root));

      Console.WriteLine("What a wonderful World!");
    }

    static bool IsBst(TreeNode node)
    {
      int min = Int32.MinValue;
      int max = Int32.MaxValue;
      return IsBstHelper(node, min, max);

    }

    static bool IsBstHelper(TreeNode node, int min, int max)
    {
      if (node == null)
        return true;

      if (node.Value < min || node.Value > max)
        return false;

      return IsBstHelper(node.Left, min, node.Value) && IsBstHelper(node.Right, node.Value, max);
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
