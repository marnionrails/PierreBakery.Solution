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
      if (this.Quantity == 1)
      {
        this.Cost = 5.00;
      }
      else if (this.Quantity == 2)
      {
        this.Cost = 10.00;
      }
      else if (this.Quantity == 3)
      {
        this.Cost = 10.00;
      }
      return this.Cost;
    }

  }
}