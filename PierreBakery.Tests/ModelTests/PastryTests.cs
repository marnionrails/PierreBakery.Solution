using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.TestTools
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry testPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), testPastry.GetType());
    }
    [TestMethod]
    public void GetPastryQuantity_GetPastryQuantity_Int()
    {
      int pastryAmount = 1;
      Pastry testPastry = new Pastry(pastryAmount);
      int result = testPastry.Quantity;
      Assert.AreEqual(pastryAmount, result);
    }
    [TestMethod]
    public void SetPastryQuantity_SetPastryQuantity_Int()
    {
      int pastryAmount = 2;
      Pastry testPastry = new Pastry(3);
      int result = testPastry.Quantity = 2;
      Assert.AreEqual(pastryAmount, result);

    }
  }
}