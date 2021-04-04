using System;

namespace SequenceExistInTreeFromRootToLeaf
{
	class Program
	{
    /*
		 * Given a binary tree and a number sequence, find if the sequence is present as a root-to-leaf path in the given tree.
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
      int[] sequence = { 1, 9, 7 };
      Console.WriteLine(DoesSequenceExist(root, sequence));

      TreeNode root1 = new TreeNode(1);
      root1.Left = new TreeNode(9);
      root1.Right = new TreeNode(9);
     // root1.Left.Left = new TreeNode(7);
      root1.Left.Right = new TreeNode(9);
      root1.Right.Left = new TreeNode(10);
      root1.Right.Right = new TreeNode(7);
      Console.WriteLine(DoesSequenceExist(root1, sequence));

      Console.WriteLine("Hello Hello World!");
    }

    static bool DoesSequenceExist(TreeNode root, int[] sequence)
    {
      return DoesSequenceExistHelper(root, 0, sequence);
    }

    static bool DoesSequenceExistHelper(TreeNode node, int level, int[] sequence)
    {
      if (node == null)
        return false;
      if (sequence[level] != node.Value || level >= sequence.Length)
      {
        return false;
      }

      if (node.Left == null && node.Right == null && sequence[level] == node.Value)
      {
        return true;
      }

      int curLevel = level + 1;

      return DoesSequenceExistHelper(node.Left, curLevel, sequence) || DoesSequenceExistHelper(node.Right, curLevel, sequence);

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
