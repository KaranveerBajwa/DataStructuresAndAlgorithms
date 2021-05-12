using System;

namespace FractionlKnapsack
{
  class Program
  {
    static void Main(string[] args)
    {
      Item[] items = { new Item(50, 600), new Item(20,500), new Item(30,400)};
      Array.Sort(items);
      Console.WriteLine(MaxValue(items, 70));

      Item[] items1 = { new Item(10,200), new Item(5,50), new Item(20,200) };
      Array.Sort(items1);
      Console.WriteLine(MaxValue(items1, 15));


      Console.WriteLine("What a wonderful World!");
    }

    // sort by value/weight
    // whichever has more value per weight should be considered first

    static int MaxValue(Item[] items, int maxWeight)
    {
      int totalValue = 0;

      for (int i = 0; i < items.Length; i++)
      {
        if (maxWeight >= items[i].Weight)
        {
          totalValue += items[i].Value;
          maxWeight = maxWeight - items[i].Weight;
        }
        else
        {
          totalValue = totalValue + (items[i].Value / items[i].Weight) * maxWeight;
          break;
        }
      }

      return totalValue;
    }
  
  }

  public class Item : IComparable<Item>
  { 
    public int Weight { get; private set; }
    public int Value { get; private set; }

    public Item(int weight, int value)
    {
      Weight = weight;
      Value = value;
    }

    public int CompareTo(Item item)
    {
      // decreasing order
      return item.Value / item.Weight - this.Value / this.Weight;
    }

  }

}
