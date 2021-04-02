using System;
using System.Collections.Generic;

namespace PalidromeLinkedList
{
  class Program
  {
/*
* Given the head of a singly linked list, return true if it is a palindrome.
Example 1:
Input: head = [1,2,2,1]
Output: true
Example 2:
Input: head = [1,2]
Output: false

Constraints:
The number of nodes in the list is in the range [1, 105].
0 <= Node.val <= 9 

Follow up: Could you do it in O(n) time and O(1) space?
     */
    static void Main(string[] args)
    {
      ListNode list = new ListNode(1);
      list.next = new ListNode(2);
      //list.next.next = new ListNode(2);
      //list.next.next.next = new ListNode(1);
      Console.WriteLine(IsPalindrome(list));
      Console.WriteLine("Hello World!");
    }

    public static bool IsPalindrome(ListNode head)
    {
      Stack<int> nodes = new Stack<int>();
      ListNode node = head;

      while (node != null)
      {
        nodes.Push(node.val);
        node = node.next;
      }

      node = head;
      while (nodes.Count > 0)
      {
        if (node.val != nodes.Pop())
          return false;
        node = node.next;
      }
      return true;
    }
  }
  public class ListNode
  {
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
      this.val = val;
      this.next = next;
    }
  }

}