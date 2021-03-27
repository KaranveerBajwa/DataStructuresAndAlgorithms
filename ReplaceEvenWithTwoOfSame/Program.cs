using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceEvenWithTwoOfSame
{
  class Program
  {
    /*
     * Test cases:
     * [], [1],[2],[2,3,4,5], [3,3,3,3],[-1]
     * empty, single even, single odd,all even, all odd , mix of even and odd
     * */
    
    static void Main(string[] args)
    {
      int[] arr = { 1,1,1,1,1};
      InsertEvenTwice(arr, 4);
      Console.WriteLine(String.Join(",", arr));
      Console.ReadKey();
    }


    static void InsertEvenTwice(int[] arr, int endIndex)
    {
      if (arr == null || arr.Length == 0)
        return;
      int insertIndex = arr.Length - 1;

      for (int i = endIndex; i >= 0; i--)
      {
        arr[insertIndex--] = arr[i];
        if (arr[i] % 2 == 0)
          arr[insertIndex--] = arr[i];
      }
    }
  }
}
