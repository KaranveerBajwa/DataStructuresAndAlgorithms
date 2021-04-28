using System;

namespace EggDrop
{
  class Program
  {
    static void Main(string[] args)
    {
      int n = 2;
      int k = 10;
      Console.WriteLine(EggDrop(2,10));
      Console.WriteLine("What a wonderful World!");
    }

    // n is the number of eggs and k is the floors
    static int EggDrop(int n, int k)
    { 
      if(k==0 || k==1) // if you are on 0th floor or first floor
          return k;

      if (n == 1) // if there is 1 egg , we need k trials
        return k;
      int min = Int32.MaxValue;
      int res;
      for (int i = 1; i < k; i++)
      {
        res =  Math.Max(
            EggDrop(n - 1, i - 1), // egg breaks
            EggDrop(n, k - i) // if egg does not break
          );
        if (res < min)
          min = res;
      }
      return min + 1;
    }

  }
}
