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
      double singlePastries = this.Quantity % 3;
      double everyThreePastries = (this.Quantity - singlePastries) /3;
      return singlePastries * 2 + everyThreePastries * 5;
    }
  }
}