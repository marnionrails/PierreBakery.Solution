using System;
namespace PierreBakery.Models
{
    public class Bread 
    {
    public int Quantity { get; set; }
    public double Cost { get; set; }

    public Bread(int quantity)
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
      double listCost = 5.00 * this.Quantity;
      double freeLoaves = (this.Quantity - this.Quantity % 3) / 3;
      double discountedCost = 5.00 * freeLoaves;
      return listCost - discountedCost;
    }

  }
}