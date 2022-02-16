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
      double listCost = this.Quantity * 2.00;
      return listCost;
    }
  }
}