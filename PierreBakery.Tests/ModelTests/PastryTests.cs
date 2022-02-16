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
    [TestMethod]
    public void GetCost_GetCost_Double()
    {
      Pastry testPastry = new Pastry(1);
      double testCost = 0.00;
      Assert.AreEqual(testCost, testPastry.Cost);
    }
    [TestMethod]
    public void CalculateTotalPastryCost_GetTotalPastryCost_Double()
    {
      Pastry testPastry = new Pastry(1);
      double pastryCost = 2.00;
      double result = testPastry.TotalCost();
      Assert.AreEqual(pastryCost, result);
    }
    [TestMethod]
    public void CalculatePastryListCost_GetPastryListCost_Double()
    {
      Pastry testPastry = new Pastry(2);
      double pastryCost = 4.00;
      double result = testPastry.TotalCost();
      Assert.AreEqual(pastryCost, result);
    }
  }
}