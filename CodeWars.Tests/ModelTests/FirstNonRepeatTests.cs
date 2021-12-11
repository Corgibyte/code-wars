using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars.Models;

namespace CodeWars.Tests
{
  [TestClass]
  public class FirstNonRepeatTests
  {
    [TestMethod]
    public void FirstNonRepeatingLetter_EmptyString_EmptyString()
    {
      Assert.AreEqual("", FirstNonRepeat.FirstNonRepeatingLetter(""));
    }

    [TestMethod]
    public void FirstNonRepeatingLetter_OneCharString_SingleChar()
    {
      Assert.AreEqual("a", FirstNonRepeat.FirstNonRepeatingLetter("a"));
    }

    [TestMethod]
    public void FirstNonRepeatingLetter_TwoCharStringDifferent_SingleChar()
    {
      Assert.AreEqual("a", FirstNonRepeat.FirstNonRepeatingLetter("ab"));
    }

    [TestMethod]
    public void FirstNonRepeatingLetter_TwoCharStringSame_EmptyString()
    {
      Assert.AreEqual("", FirstNonRepeat.FirstNonRepeatingLetter("aa"));
    }

    [TestMethod]
    public void FirstNonRepeatingLetter_WordWithRepeatThenNonRepeat_CorrectCharString()
    {
      Assert.AreEqual("t", FirstNonRepeat.FirstNonRepeatingLetter("stress"));
    }
  }
}