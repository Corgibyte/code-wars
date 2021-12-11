using System;

namespace CodeWars.Models
{
  //TODO: Seems to pass tests, but is too slow
  public class PerfectPower
  {
    public static (int, int)? IsPerfectPower(int n)
    {
      int sqrtN = (int)Math.Ceiling(Math.Sqrt(n));
      for (int i = 2; i < sqrtN; i++)
      {
        int lastPower = i;
        for (int j = 1; lastPower < n; j++)
        {
          lastPower = (int)Math.Pow(i, j);
          if (lastPower == n)
          {
            return (i, j);
          }
        }
      }
      return null;
    }
  }
}
