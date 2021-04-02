using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
  public class Node
  {
    public int Value { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }

    public Node()
    {      
    }

    public Node(int val)
    {
      Value = val;
    }

    public static void BuildTree(Node node)
    {
      node = new Node(1);
      node.Left = new Node(2);
      node.Left.Left = new Node(3);
      node.Left.Right = new Node(4);

      node.Right = new Node(5);
      node.Right.Right = new Node(6);

    }

  }
}
