using System;
using System.Collections.Generic;

namespace AreTwoTreesIdentical
{
  class Program
  {
    static void Main(string[] args)
    {
      TreeNode root = new TreeNode(12);
      root.Left = new TreeNode(7);
      root.Right = new TreeNode(9);
      root.Left.Left = new TreeNode(4);
      root.Left.Right = new TreeNode(5);
      root.Right.Left = new TreeNode(2);
      //root.Right.Right = new TreeNode(7);

      TreeNode root2 = new TreeNode(12);
      root2.Left = new TreeNode(7);
      root2.Right = new TreeNode(1);
      root2.Left.Left = new TreeNode(4);
      root2.Right.Left = new TreeNode(10);
      root2.Right.Right = new TreeNode(5);
      root2.Right.Right.Right = new TreeNode(5);

      TreeNode root1 = new TreeNode(12);
      root1.Left = new TreeNode(7);
      root1.Right = new TreeNode(1);
      root1.Left.Left = new TreeNode(4);
      root1.Right.Left = new TreeNode(10);
      root1.Right.Right = new TreeNode(5);

     // Console.WriteLine($"Are trees Identical: {AreTreesIdenticalDFS(root, root1)}");
      //  Console.WriteLine($"Are trees Identical: {AreTreesIdentical(root1, root2)}");

      Console.WriteLine($"Are trees Identical: {AreTreesIdenticalBFS(root, root1)}");
      Console.WriteLine($"Are trees Identical: {AreTreesIdenticalBFS(root1, root2)}");

    }

    static bool AreTreesIdenticalDFS(TreeNode node1, TreeNode node2)
    {
      var val = node1 == null ? "Empty" : (node1.Value).ToString();
      var val2 = node2 == null ? "Empty" : (node2.Value).ToString();

      Console.WriteLine($"AreTreesIdentical({val}, {val2})");

      if (node1 == null && node2 == null)
        return true;

      if (node1 == null || node2 == null)
        return false;


      if (node1.Value == node2.Value
        && AreTreesIdenticalDFS(node1.Left, node2.Left)
        && AreTreesIdenticalDFS(node1.Right, node2.Right))
      {
        return true;
      }
      return false;
    }


    static bool AreTreesIdenticalBFS(TreeNode node1, TreeNode node2)
    {
      Queue<TreeNode> q1 = new Queue<TreeNode>();
      Queue<TreeNode> q2 = new Queue<TreeNode>();
      q1.Enqueue(node1);
      q2.Enqueue(node2);
      TreeNode n1;
      TreeNode n2;
      while (q1.Count > 0 && q2.Count > 0)
      {
        node1 = q1.Dequeue();
        node2 = q2.Dequeue();
        if (!Check(node1, node2))
          return false;

        if (node1 != null)
        {
            q1.Enqueue(node1.Left);
            q2.Enqueue(node2.Left);

            q1.Enqueue(node1.Right);
            q2.Enqueue(node2.Right);
        }
        // at each step we check if the nodes data is equal 
        // insert the left and right child in queue
      }


      return true;
      // if there are any elements left in any of the queue return false
      // else return true

    }

    private static bool Check(TreeNode node1, TreeNode node2)
    {
      if (node1 == null && node2 == null)
        return true;
      if (node1 == null || node2 == null)
        return false;
      if (node1.Value != node2.Value)
        return false;
      return true;
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
