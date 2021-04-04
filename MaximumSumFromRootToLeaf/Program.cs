using System;

namespace MaximumSumFromRootToLeaf
{
  /*
   * Find maxiumum Root to Leaf sum in binary tree
   */
  class Program
  {
    static void Main(string[] args)
    {
      TreeNode root = new TreeNode(1);
      root.Left = new TreeNode(7);
      root.Right = new TreeNode(9);
      root.Left.Left = new TreeNode(4);
      root.Left.Right = new TreeNode(5);
      root.Right.Left = new TreeNode(2);
      root.Right.Right = new TreeNode(7);
      Console.WriteLine(GetMaximumSum(root));


      TreeNode root1 = new TreeNode(12);
      root1.Left = new TreeNode(7);
      root1.Right = new TreeNode(1);
      root1.Left.Left = new TreeNode(4);
      root1.Right.Left = new TreeNode(10);
      root1.Right.Right = new TreeNode(15);
      Console.WriteLine(GetMaximumSum(root1));

      Console.WriteLine("Hello World!");
    }

    static int GetMaximumSum(TreeNode root)
    {
      int[] maxSum = { Int32.MinValue };
      GetMaximumSumHelper(root, 0, maxSum);
      return maxSum[0];
    }

    static void GetMaximumSumHelper(TreeNode node, int sum, int[] maxSum)
    {
      if (node == null)
        return;

      int curSum = sum + node.Value;
      if (node.Left == null && node.Right == null && maxSum[0] < curSum)
      {
        maxSum[0] = curSum;
      }

      GetMaximumSumHelper(node.Left, curSum, maxSum);
      GetMaximumSumHelper(node.Right, curSum, maxSum);

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
