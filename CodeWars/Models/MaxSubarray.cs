using System;

namespace CodeWars.Model
{
  public class MaxsubArray
  {

    public static int MaxSequence(int[] arr)
    {
      int maxSum = 0;
      for (int i = 0; i < arr.Length; i++)
      {
        int currSum = arr[i];
        for (int j = i + 1; j < arr.Length && currSum > 0; j++)
        {
          Console.WriteLine($"j : {j}");
          currSum += arr[j];
          if (currSum > maxSum)
          {
            maxSum = currSum;
          }
        }
      }
      return maxSum;
    }
  }
}