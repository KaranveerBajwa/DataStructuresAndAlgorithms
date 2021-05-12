using System;

namespace InsertElementAtIndex
{
  class Program
  {
    static void Main(string[] args)
    {
      InsertAt(new int[] { 1, 2, 3, 4, 5, 0 }, 2, 55, 6);
      Console.WriteLine("What a wonderful World!");
    }

    static void InsertAt(int[] nums, int index, int value, int size)
    {
      if (nums == null )
        throw new ArgumentException("Invalid inputs");

      for (int i = size - 1; i > index; i--)
      {
        nums[i] = nums[i - 1]; 
      }
      nums[index] = value;

    }
  }
}
