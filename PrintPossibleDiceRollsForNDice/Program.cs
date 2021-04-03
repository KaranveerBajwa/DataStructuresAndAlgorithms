using System;
using System.Collections.Generic;

namespace PrintPossibleDiceRollsForNDice
{
  class Program
  {
    static void Main(string[] args)
    {
      PrintDiceRolls(3);

      List<List<int>> possibleDiceRolls = GetListOfDiceRolls(3);
      Console.WriteLine("Hello World!");
    }

    static void PrintDiceRolls(int n)
    {
      List<int> diceRolls = new List<int>();
      PrintDiceRollsHelper(n, diceRolls);
    }

    static List<List<int>> GetListOfDiceRolls(int n)
    {
      List<int> diceRolls = new List<int>();
      List<List<int>> possibleDiceRolls = new List<List<int>>();
      GetListOfDiceRollsHelper(n, diceRolls, possibleDiceRolls);
      return possibleDiceRolls;
    }

    static void GetListOfDiceRollsHelper(int n, List<int> diceRolls, List<List<int>> possibleDiceRolls)
    {
      if (n == 0)
      {
        possibleDiceRolls.Add(new List<int>(diceRolls));
      }
      else
      {
        for (int i = 1; i <= 6; i++)
        {
          diceRolls.Add(i);
          GetListOfDiceRollsHelper(n - 1, diceRolls, possibleDiceRolls);
          diceRolls.RemoveAt(diceRolls.Count - 1);
        }
      }
    }

    static void PrintDiceRollsHelper(int n, List<int> diceRolls)
    {
      if (n == 0)
      {
        Print(diceRolls);
      }
      else
      {
        for (int i = 1; i <= 6; i++)
        {
          diceRolls.Add(i);
          PrintDiceRollsHelper(n - 1, diceRolls);
          diceRolls.RemoveAt(diceRolls.Count - 1);
        }      
      }

    }

    private static void Print(List<int> diceRolls)
    {
      Console.Write(String.Join(",", diceRolls));
      Console.WriteLine();
    }
  }
}
