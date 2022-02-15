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

    public double TotalCost()
    {
      if (this.Quantity == 1)
      {
        this.Cost = 2.00;
      }
      return this.Cost;
    }
  }
}