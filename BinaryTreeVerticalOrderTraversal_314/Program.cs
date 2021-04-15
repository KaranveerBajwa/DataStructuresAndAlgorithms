using System;
using System.Collections.Generic;

namespace BinaryTreeVerticalOrderTraversal_314
{
  /*
   * Given the root of a binary tree, return the vertical order traversal of its nodes' values. (i.e., from top to bottom, column by column).
    If two nodes are in the same row and column, the order should be from left to right.
    https://leetcode.com/problems/binary-tree-vertical-order-traversal/
   */
  class Program
  {
    static void Main(string[] args)
    {
      TreeNode root = new TreeNode(3);
      root.Left = new TreeNode(9);
      root.Left.Left = new TreeNode(4);
      root.Left.Right = new TreeNode(0);

      root.Right = new TreeNode(8);
      root.Right.Left = new TreeNode(1);
      root.Right.Right = new TreeNode(7);
      var res = VerticalOrder(root);

      Console.WriteLine("What a wonderful World!");
    }

    static IList<IList<int>> VerticalOrder(TreeNode root)
    {
      Dictionary<int, List<int>> hdList = new Dictionary<int, List<int>>();

      if (root == null)
        return null;

      Queue<NodeInfo> queue = new Queue<NodeInfo>();
      queue.Enqueue(new NodeInfo(root, 0));
      int minHd = Int32.MaxValue;
      int maxHd = Int32.MinValue;

      while (queue.Count > 0)
      {
        NodeInfo nInfo = queue.Dequeue();
        if (!hdList.ContainsKey(nInfo.HorizentalDistance))
          hdList.Add(nInfo.HorizentalDistance, new List<int>());
        hdList[nInfo.HorizentalDistance].Add(nInfo.Node.Value);

        if (nInfo.Node.Left != null)
        {
          int hd = nInfo.HorizentalDistance - 1;
          queue.Enqueue(new NodeInfo(nInfo.Node.Left, hd));
          if (hd < minHd)
            minHd = hd;
        }

        if (nInfo.Node.Right != null)
        {
          int hd = nInfo.HorizentalDistance + 1;
          queue.Enqueue(new NodeInfo(nInfo.Node.Right, hd));
          if (hd > maxHd)
            maxHd = hd;
        }
      }

      IList<IList<int>> list = new List<IList<int>>();
      for (int i = minHd; i <= maxHd; i++)
      {
        if (hdList.ContainsKey(i))
          list.Add(new List<int>(hdList[i]));
      }

      return list;
    }
  }

  public class NodeInfo
  {
    public TreeNode Node;
    public int HorizentalDistance;
    public NodeInfo(TreeNode node, int hd)
    {
      Node = node;
      HorizentalDistance = hd;
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
