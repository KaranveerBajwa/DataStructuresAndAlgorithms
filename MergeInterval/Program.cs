using System;
using System.Collections.Generic;

namespace MergeInterval
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Interval> intervals = new List<Interval>();
      intervals.Add(new Interval(1, 3));
      intervals.Add(new Interval(2, 4));
      intervals.Add(new Interval(5, 6));
      intervals.Add(new Interval(6, 7));
      intervals.Sort();

      var result = MergeIntervals(intervals);

      // 6,7 [2,4] 5,9

      List<Interval> intervals1 = new List<Interval>();
      intervals1.Add(new Interval(6, 7));
      intervals1.Add(new Interval(2, 4));
      intervals1.Add(new Interval(5, 9));

      intervals1.Sort();

      var results1 = MergeIntervals(intervals1);

    }

      static List<Interval> MergeIntervals(List<Interval> intervals)
      {
        if (intervals == null || intervals.Count == 0)
          throw new ArgumentNullException("Please provide intervals to merge");
        List<Interval> mergedIntervals = new List<Interval>();
        int start = intervals[0].Start;
        int end = intervals[0].End;
        for (int i = 1; i < intervals.Count; i++)
        {
          if (intervals[i].Start <= end)
          {
            if (intervals[i].End > end)
            {
              end = intervals[i].End;
            }
          }
          else
          {
            mergedIntervals.Add(new Interval(start, end));
            start = intervals[i].Start;
            end = intervals[i].End;
          }
        }
        mergedIntervals.Add(new Interval(start, end));

        return mergedIntervals;
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

