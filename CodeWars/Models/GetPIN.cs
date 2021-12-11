using System.Collections.Generic;

namespace CodeWars.Models
{
  public class GetPIN
  {
    public static List<string> GetPINs(string observed)
    {
      List<string> possibilities = new List<string>() { };
      AddPossibilities(possibilities, "", observed);
      return possibilities;
    }

    public static void AddPossibilities(List<string> possibilities, string locked, string loose)
    {
      if (loose == "")
      {
        possibilities.Add(locked);
      }
      else
      {
        string lockingDigit = loose.Substring(0, 1);
        string newLoose = loose.Substring(1);
        List<int> lockingAdjacents = getAdjacents(int.Parse(lockingDigit));
        foreach (int adjacent in lockingAdjacents)
        {
          AddPossibilities(possibilities, locked + adjacent, newLoose);
        }
      }
    }

    public static List<int> getAdjacents(int num)
    {
      List<int> adjacents = new List<int>() { num };
      if (num == 0)
      {
        adjacents.Add(8);
      }
      if (num != 0)
      {
        if (num == 8)
        {
          adjacents.Add(0);
        }
        if (num - 1 > 0 && num % 3 != 1)
        {
          adjacents.Add(num - 1);
        }
        if (num - 3 > 0)
        {
          adjacents.Add(num - 3);
        }
        if (num + 1 < 10 && num % 3 != 0)
        {
          adjacents.Add(num + 1);
        }
        if (num + 3 < 10)
        {
          adjacents.Add(num + 3);
        }
      }
      return adjacents;
    }
  }
}