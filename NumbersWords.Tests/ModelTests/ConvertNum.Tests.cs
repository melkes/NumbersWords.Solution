using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NumbersWords.Models;

namespace NumbersWords.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
      public void Dispose()
    {
      Number.ClearAll();
    }

    [TestMethod]
    public void Log_Input()
    {
      int num = 12;
      Number test = new Number(num);
      Assert.AreEqual(typeof(Number), test.GetType());
      Assert.AreEqual(12, test.InputNum);
    }

    [TestMethod]
    public void Convert_returnWords_String()
    {
      Number test = new Number(15);
      string testString = "fifteen";
      Assert.AreEqual(testString, test.Convert(test.InputNum));
    }
  
    [TestMethod]
    public void Convert_returnWordsBiggerThan20_String()
    {
      Number test = new Number(35);
      string testString = "thirty five";
      Assert.AreEqual(testString, test.Convert(test.InputNum));
    }

    [TestMethod]
    public void Convert_returnWordsBiggerThan100_String()
    {
      Number test = new Number(111);
      string testString = "one hundred eleven";
      Assert.AreEqual(testString, test.Convert(test.InputNum));
    }

    [TestMethod]
    public void Convert_returnWordsBiggerThan500_String()
    {
      Number test = new Number(546);
      string testString = "five hundred forty six";
      Assert.AreEqual(testString, test.Convert(test.InputNum));
    }

    [TestMethod]
    public void Convert_returnWordsBiggerThan1000_String()
    {
      Number test = new Number(1546);
      string testString = "one thousand five hundred forty six";
      Assert.AreEqual(testString, test.intToString());
    }
    
    [TestMethod]
    public void Convert_returnWordsBiggerThan100_000_String()
    {
      Number test = new Number(154691);
      string testString = "one hundred fifty four thousand six hundred ninety one";
      Assert.AreEqual(testString, test.intToString());
    }

    [TestMethod]
    public void Convert_returnWordsBiggerThan100_000_000_String()
    {
      Number test = new Number(731546910);
      string testString = "seven hundred thirty one million five hundred forty six thousand nine hundred ten";
      Assert.AreEqual(testString, test.intToString());
    }

    // [TestMethod]
    // public void Convert_returnWordsBiggerThan100_000_000_000String()
    // {
    //   Number test = new Number(154691845236);
    //   string testString = "one hundred fifty four billion six hundred ninety one million eight hundred forty five thousand two hundred thirty six";
    //   Assert.AreEqual(testString, test.intToString());
    // }
  }
}