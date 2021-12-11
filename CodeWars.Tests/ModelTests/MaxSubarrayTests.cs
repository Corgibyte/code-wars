using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars.Model;

namespace CodeWars.Tests
{
  [TestClass]
  public class MaxsubarrayTests
  {
    [TestMethod]
    public void MaxSequence_LongArray_Int()
    {
      int[] testArr = { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 11, 13, 15, 17 };
      Assert.AreEqual(90, MaxsubArray.MaxSequence(testArr));
    }
  }
}