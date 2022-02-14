using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.TestTools
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread testBread = new Bread(2);
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }
    [TestMethod]
    public void GetQuantity_GetQuantity_Int()
    {
      int testQuantity = 0;
      Bread testBread = new Bread(testQuantity);
      Assert.AreEqual(testQuantity, testBread.Quantity);
    }
  }
}

