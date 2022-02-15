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
  }
}