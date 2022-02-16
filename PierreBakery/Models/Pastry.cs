using System;
namespace PierreBakery.Models
{
  public class Pastry
  {
    public int Quantity { get; set; }
    public double Cost { get; set; }
  
    public Pastry(int quantity)
    {
      Quantity = quantity;
    }
      public string CheckForValidInput()
    {
      if (this.Quantity >= 0)
      {
        return "Order coming up!";
      }
      else
      {
        return "Input must be an integer greater than or equal to 0";
      }
    }
    
    public double TotalCost()
    {
      double singlePastries = this.Quantity % 3;
      double everyThreePastries = (this.Quantity - singlePastries) /3;
      return singlePastries * 2 + everyThreePastries * 5;
    }
  }
}