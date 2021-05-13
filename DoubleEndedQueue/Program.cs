using System;

namespace DoubleEndedQueue
{
  class Program
  {
    static void Main(string[] args)
    {
      Deque deque = new Deque(5);
      deque.InsertFront(10);
      deque.InsertFront(20);
      deque.InsertRear(30);
      deque.InsertRear(60);
      deque.InsertFront(5);
      //deque.DeleteRear();
      //deque.InsertFront(55);
      Console.WriteLine(deque.GetFront());
      Console.WriteLine(deque.GetRear());
      Console.WriteLine("What a wonderful World!");
    }
  }


  public class Deque
  {
    public int Count;
    int size;
    int front;
    int rear;
    int[] arr;
    public Deque(int n)
    {
      arr = new int[n];
      size = n;
      Count = 0;
      front = -1;
      rear = -1;    
    }

    public void InsertFront(int n)
    {
      if (Count == size)
        throw new Exception("Queue is full");
        front = (front - 1 + size) % size;      
      arr[front] = n;
      Count++;
    }

    public void InsertRear(int n)
    {
      if (Count == size)
        throw new Exception("Queue is full");
      if (Count == 0)
      {
        front = 0;
        rear = 0;
      }
      else
        rear = (rear + 1) % size;

      arr[rear] = n;
      Count++;
    }

    public int DeleteFront()
    {
      if (Count == 0)
        throw new Exception("Queue is empty");
      int res = arr[front];
      front = (front + 1) % size;
      Count = Count - 1;
      if (Count == 0)
      {
        front = -1;
        rear = -1;
      }
      return res;
    }

    public int DeleteRear()
    {
      if (Count == 0)
        throw new Exception("Queue is empty");

      int res = arr[rear];
      rear = (rear - 1 + size) % size;
      Count = Count - 1;
      if (Count == 0)
      {
        front = -1;
        rear = 1;
      }
      return res;
    
    }

    public int GetFront()
    {
      if (Count == 0)
        throw new Exception("Queue is empty");

      return arr[front];
    }

    public int GetRear()
    {
      if (Count == 0)
        throw new Exception("Queue is empty");
      return arr[rear];
    }


  }
}
