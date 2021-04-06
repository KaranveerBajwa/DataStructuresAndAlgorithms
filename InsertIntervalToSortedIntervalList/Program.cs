using System;
using System.Collections.Generic;

namespace InsertIntervalToSortedIntervalList
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Interval> list = new List<Interval>();
      list.Add(new Interval(3,5));
      list.Add(new Interval(9, 11));
      list.Add(new Interval(15,17));
     // Interval interval = new Interval(1, 2);
     // Interval interval = new Interval(7, 10);
      Interval interval = new Interval(7, 16);
      var res = InsertInterval(list, interval);
    }

    static List<Interval> InsertInterval(List<Interval> list, Interval interval)
    {
      List<Interval> mergedList = new List<Interval>();
      if(list == null || list.Count ==0)
      {
        mergedList.Add(interval);
        return mergedList;
      }

      int start = interval.Start;
      int end = interval.End;
      int i = 0;

      while (i < list.Count && list[i].End < start)
      {
        mergedList.Add(list[i]);
        i++;
      }

      while (i < list.Count && list[i].Start <= end)
      {
        start = Math.Min(start, list[i].Start);
        end = Math.Max(end, list[i].End);
        i++;
      }
      mergedList.Add(new Interval(start, end));

      while (i < list.Count)
      {
        mergedList.Add(list[i]);
        i++;
      }

      return mergedList;
    }
  }

  public class Interval:IComparable<Interval>
  {
    public int Start { get; set; }
    public int End { get; set; }

    public Interval(int start, int end)
    {
      Start = start;
      End = end;
    }

    public int CompareTo(Interval interval)
    {
      return this.Start.CompareTo(interval.Start);
    }
  }
}
