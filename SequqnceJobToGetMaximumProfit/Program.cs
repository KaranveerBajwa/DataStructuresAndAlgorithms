using System;

namespace SequqnceJobToGetMaximumProfit
{
  class Program
  {
    static void Main(string[] args)
    {
      Job[] jobs = { new Job(4,70), new Job(1,80), new Job(1,30), new Job(1,100) };
      Array.Sort(jobs);
      Console.WriteLine(MaxProfit(jobs));

     Job[] jobs1 = { new Job(2,50), new Job(2,60), new Job(3,20), new Job(3,30) };
      Array.Sort(jobs1);
      Console.WriteLine(MaxProfit(jobs1));
      //      Job[] jobs2 = { new Job(), new Job(), new Job(), new Job() };

      Console.WriteLine("Hello World!");
    }

    static int MaxProfit(Job[] jobs)
    {
      Job[] res = new Job[jobs.Length];
      int profit = 0;

      for (int i = 0; i < jobs.Length; i++)
      {
        int endTime =jobs[i].Deadline - 1;
        if (res[endTime] == null)
        {
          res[endTime] = jobs[i];
          profit += jobs[i].Profit;

        }
        else
        {
          endTime = endTime - 1;
          while (endTime >= 0)
          {
            if (res[endTime] == null)
            {
              res[endTime] = jobs[i];
              profit += jobs[i].Profit;
              break;
            }
            endTime--;
          }
        }
      }
      return profit;

    }
  }

  public class Job : IComparable<Job>
  { 
    public int Deadline { get; private set; }
    public int Profit { get; private set; }

    public Job(int end, int profit)
    {
      Deadline = end;
      Profit = profit;
    }

    public int CompareTo(Job job)
    {
      return job.Profit -this.Profit;
    }

  }
}
