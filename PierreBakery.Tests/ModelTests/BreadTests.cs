using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;

namespace PierreBakery.TestTools {

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
    [TestMethod]
    public void SetQuantity_SetQuantity_Int()
    {
      int testQuantity = 2;
      Bread testBread = new Bread(1);
      testBread.Quantity = 2;
      Assert.AreEqual(testQuantity, testBread.Quantity);
    }
    [TestMethod]
    public void GetCost_GetCost_Double()
    {
      Bread testBread = new Bread(2);
      double testCost = 0.00;
      Assert.AreEqual(testCost, testBread.Cost);
    }
    [TestMethod]
    public void CalculateTotalLoafCost_GetTotalLoafCost_Double()
    {
      Bread testBread = new Bread(1);
      double loafCost = 5.00;
      double result = testBread.TotalCost();
      Assert.AreEqual(loafCost, result);
    }
    [TestMethod]
    public void CalculateCostOfTwoLoaves_GetCostOfTwoLoaves_Double()
    {
      Bread testBread = new Bread(2);
      double twoLoafCost = 10.00;
      double result = testBread.TotalCost();
      Assert.AreEqual(twoLoafCost, result);
    }
    [TestMethod]
    public void CalculateCostOfThreeLoaves_GetCostOfThreeLoaves_Double()
    {
      Bread testBread = new Bread(3);
      double threeLoafCost = 10.00;
      double result = testBread.TotalCost();
      Assert.AreEqual(threeLoafCost, result);
    }
  }
}


