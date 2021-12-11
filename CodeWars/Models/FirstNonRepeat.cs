using System;
using System.Collections.Generic;

namespace CodeWars.Models
{
  public class FirstNonRepeat
  {
    public static string FirstNonRepeatingLetter(string s)
    {
      Queue<string> letters = new Queue<string>() { };
      for (int i = 0; i < s.Length; i++)
      {
        letters.Enqueue(s.Substring(i, 1));
      }
      return Dive(letters);
    }

    public static string Dive(Queue<string> letters)
    {
      if (letters.Count == 0)
      {
        return "";
      }
      else if (letters.Count == 1)
      {
        return letters.Dequeue();
      }
      else
      {
        bool foundRepeat = false;
        string thisLetter = letters.Dequeue();
        Queue<string> newQueue = new Queue<string>() { };
        while (letters.Count > 0)
        {
          string nextLetter = letters.Dequeue();
          if (thisLetter.ToLower() == nextLetter.ToLower())
          {
            foundRepeat = true;
          }
          else
          {
            newQueue.Enqueue(nextLetter);
          }
        }
        if (!foundRepeat)
        {
          return thisLetter;
        }
        else
        {
          return Dive(newQueue);
        }
      }
    }
  }
}

/*
public static string FirstNonRepeatingLetter(string s)
{
  Queue<string> letters = new Queue<string>() { };
  bool foundRepeat = false;
  string repeatedLetter = "";
  while (!foundRepeat && letters.Count > 0)
  {
    (repeatedLetter, letters) = FindRepeatAndTrim(letters);
    foundRepeat = repeatedLetter != "";
  }
  return repeatedLetter;
}

public static (string, Queue<string>) FindRepeatAndTrim(Queue<string> letters)
{
  string workingLetter = letters.Dequeue();
  bool isRepeated = letters.Count == 0;
  Queue<string> workingQueue = new Queue<string>() { };
  while (letters.Count != 0)
  {
    if (letters.Peek().ToLower() != workingLetter.ToLower())
    {
      workingQueue.Enqueue(letters.Dequeue());
    }
    else
    {
      isRepeated = true;
      letters.Dequeue();
    }
  }
  if (isRepeated)
  {
    workingLetter = "";
  }
  return (workingLetter, workingQueue);
}
*/