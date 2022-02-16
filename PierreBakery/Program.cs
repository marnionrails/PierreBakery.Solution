using System;
using PierreBakery.Models;

namespace PierreBakery
{
  public class Program
  {
    public static void GetOrders()
    {
      Console.WriteLine("How many loaves of bread would you like to order today?");
      Bread breadOrder = new Bread(int.Parse(Console.ReadLine()));
      Console.WriteLine("How many pastries would you like to order today?");
      Pastry pastryOrder = new Pastry(int.Parse(Console.ReadLine()));
      if (breadOrder.CheckForValidInput() == "Order coming up!" && pastryOrder.CheckForValidInput() == "Order coming up!")
      {
        double finalCost = breadOrder.TotalCost() + pastryOrder.TotalCost();
        Console.WriteLine("Your total today is $" + finalCost);
      }
      else
      {
        Console.WriteLine("Your inputs cannot be negative. Let's try again.");
        GetOrders();
      }
    }

    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery. We serve bread and pastries.");
      Console.WriteLine("Loaves of Bread: $5 each (Buy 2, get 1 free!)");
      Console.WriteLine("Pastries: $2 each (Get 3 for $5!");
      GetOrders(); 
    }
  }
}