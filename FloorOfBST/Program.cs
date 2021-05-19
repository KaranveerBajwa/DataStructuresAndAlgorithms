using System;

namespace FloorOfBST
{
  class Program
  {
    static void Main(string[] args)
    {
      Node node = new Node(10);
      node.Left = new Node(5);
      node.Right = new Node(15);
      node.Right.Left = new Node(12);
      node.Right.Right = new Node(30);
      int target = 14;
      Node res = Floor(node, target);
      Node res1 = Ceil(node, target);
  
     // Console.WriteLine($"floor of {target} is {res.Key} and ceil is {ceil} ");
      Console.WriteLine("What a wonderful World!");
    }

    static Node Floor(Node root, int target)
    {
      Node res = null;

      while (root != null)
      {
        if (root.Key == target)
          return root;
        else if (root.Key > target)
          root = root.Left;
        else
        {
          res = root;
          root = root.Right;
        }
      }
      return res;
    }


    static Node Ceil(Node root, int target)
    {
      Node res = null;
      while (root != null)
      {
        if (root.Key == target)
          return root;
        else if (root.Key < target)
          root = root.Right;
        else
        {
          res = root;
          root = root.Left;
        }
      }
      return res;
    }
  
  }

  public class Node
  {
    public int Key;
    public Node Left;
    public Node Right;

    public Node(int x)
    {
      Key = x;
    }
  }
}
