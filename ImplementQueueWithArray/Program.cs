using System;

namespace ImplementQueueWithArray
{
  class Program
  {
    static void Main(string[] args)
    {
      Queue queue = new Queue(5);
      queue.Enqueue(5);
      queue.Enqueue(10);
      queue.Enqueue(15);
      queue.Enqueue(11);
      queue.Enqueue(12);

      var res = queue.Dequeue();
      var res1 = queue.Dequeue();
      var res2 = queue.GetFront();
      var res3 = queue.GetRear();
      queue.Dequeue();
      queue.Dequeue();
      queue.Dequeue();
      queue.Enqueue(122);
      queue.Enqueue(1112);
      Console.WriteLine("What a wonderful World!");
    }
  }

  public class Queue
  {
    int[] arr;
    int front;
    int rear;
    public int Count;
    public Queue(int size)
    {
      arr = new int[size];
      rear = -1;
      front = -1;
    }
    public void Enqueue(int n)
    {
      // increment rear and insert
      rear = (rear + 1) % arr.Length;
      arr[rear] = n;
      Count = Count + 1;
      if (front == -1)
        front = rear;

    }

    public int Dequeue()
    {
      int res = arr[front];
      front = (front + 1) % arr.Length;
      Count = Count - 1;
      return res;
    }

    public int GetFront()
    {
      return arr[front];
    }

    public int GetRear()
    {
      return arr[rear];
    }

    

    // EnQueue
    // Dequeue
    // GetFront
    //Get Rear
    //Count

  
  
  }
}
