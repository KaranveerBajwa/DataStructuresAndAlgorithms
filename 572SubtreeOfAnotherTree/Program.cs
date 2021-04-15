using System;

namespace _572SubtreeOfAnotherTree
{
  /*
   * Given two non-empty binary trees s and t, check whether tree t has exactly the same structure and node values with a subtree of s. A subtree of s is a tree consists of a node in s and all of this node's descendants. The tree s could also be considered as a subtree of itself.
   * https://leetcode.com/problems/subtree-of-another-tree/
   */
  class Program
  {
    static void Main(string[] args)
    {
      TreeNode root = new TreeNode(3);
      root.Left = new TreeNode(4);
      root.Right = new TreeNode(5);
      root.Left.Left = new TreeNode(1);
      root.Left.Right = new TreeNode(2);

      TreeNode root1 = new TreeNode(4);
      root1.Left = new TreeNode(1);
      root1.Right = new TreeNode(3);
      Console.WriteLine(IsSubtree(root, root1));
      Console.WriteLine("What a wonderful world!");
    }

    public static bool IsSubtree(TreeNode s, TreeNode t)
    {
      if (t == null)
        return true;

      if (s == null)
        return false;

      if (IsIdentical(s, t))
        return true;

      if (IsSubtree(s.Left, t) || IsSubtree(s.Right, t))
        return true;
      return false;
      // if the node value match check of the tree is identical from there 
      // if not check if the subtree exists in left or right
      //
    }

    private static  bool IsIdentical(TreeNode s, TreeNode t)
    {
      if (s == null && t == null)
        return true;

      if (s == null || t == null)
        return false;

      if (s.Value == t.Value 
        && IsIdentical(s.Left, t.Left) 
        && IsIdentical(s.Right, t.Right))
        return true;

      return false;

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
