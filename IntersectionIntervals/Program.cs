using System;
using System.Collections.Generic;

namespace IntersectionIntervals
{
  /*
   * Given two lists of intervals, find the intersection of these two lists. Each list consists of disjoint intervals sorted on their start time.
    Example 1:
    Input: arr1=[[1, 3], [5, 6], [7, 9]], arr2=[[2, 3], [5, 7]]
    Output: [2, 3], [5, 6], [7, 7]
    Explanation: The output list contains the common intervals between the two lists.

    Example 2:
    Input: arr1=[[1, 3], [5, 7], [9, 12]], arr2=[[5, 10]]
    Output: [5, 7], [9, 10]
    Explanation: The output list contains the common intervals between the two lists.
   */
  class Program
  {
    static void Main(string[] args)
    {
      List<Interval> intervals1 = new List<Interval>();
      intervals1.Add(new Interval(1, 3));
      intervals1.Add(new Interval(5, 6));
      intervals1.Add(new Interval(7, 9));
      List<Interval> intervals2 = new List<Interval>();
      intervals2.Add(new Interval(2, 3));
      intervals2.Add(new Interval(5, 7));
      var res = IntersectIntervals(intervals1, intervals2);

      Console.WriteLine("Its a wonderful World!");
    }

    static List<Interval> IntersectIntervals(List<Interval> intervals1, List<Interval> intervals2)
    {
      int i = 0; // intervals1 index
      int j = 0;// intervals2Index
      List<Interval> results = new List<Interval>();

      while (i < intervals1.Count && j < intervals2.Count)
      {
        if ((intervals1[i].Start >= intervals2[j].Start && intervals1[i].Start <= intervals2[j].End) ||
         (intervals2[j].Start >= intervals1[i].Start && intervals2[j].Start <= intervals1[i].End))
        {
          results.Add(new Interval(Math.Max(intervals1[i].Start, intervals2[j].Start),
                      Math.Min(intervals1[i].End, intervals2[j].End)));
        }

        if (intervals1[i].End <= intervals2[j].End)
        {
          i++;
        }
        else
          j++;

      }

      return results;
    }

  }
  public class Interval : IComparable<Interval>
  {

    public int Start { get; private set; }
    public int End { get; private set; }
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
