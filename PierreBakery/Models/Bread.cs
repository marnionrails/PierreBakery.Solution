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

    public double TotalCost()
    {
      double listCost = 5.00 * this.Quantity;
      double freeLoaves = (this.Quantity - this.Quantity % 3) / 3;
      double discountedCost = 5.00 * freeLoaves;
      return listCost - discountedCost;
    }

  }
}