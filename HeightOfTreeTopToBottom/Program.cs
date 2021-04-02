using BinaryTree;
using System;
using System.Xml;

namespace HeightOfTreeTopToBottom
{
  class Program
  {
    static void Main(string[] args)
    {
      Node node = new Node(1);
      node.Left = new Node(2);
      node.Left.Left = new Node(3);
      node.Left.Right = new Node(4);
      node.Left.Right.Right = new Node(9);
      node.Left.Right.Right.Right = new Node(10);

      node.Right = new Node(5);
      node.Right.Right = new Node(6);
      int[] maxHeight = { 0 };
      MaxHeight(node, 0, maxHeight);
      Console.WriteLine(maxHeight[0]);
      maxHeight = new int[1];
      Node node1 = new Node(1);
      MaxHeight(node1, 0, maxHeight);

    }

    static void MaxHeight(Node curr, int height, int[] maxHeight)
    {
      if (curr == null)
        return;

      int curHeight = height + 1;

      if (maxHeight[0] < curHeight)
        maxHeight[0] = curHeight;

      MaxHeight(curr.Left, curHeight, maxHeight);
      MaxHeight(curr.Right, curHeight, maxHeight);
    }
  }
}
