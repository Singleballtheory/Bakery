using System;
using System.Collections.Generic;

namespace Offers.Models
{
  public class Bread
  {
    public int Amount { get; set; }
    public int Price { get; set; }
    public Bread(int amount, int price = 0)
    {
      Amount = amount;
      Price = price;
    }
    public int SetPrice()
    {
      if (Amount > 2)
      {
        Price = ((Amount * 5) - ((Amount / 3 ) * 5));
        return Price;
      }
      Price = Amount * 5;
      return Price;
    }
  }
  public class Pastry
  {
    public int Amount { get; set; }
    public int Price { get; set; }
    public Pastry(int amount, int price = 0)
    {
      Amount = amount;
      Price = price;
    }
    public int SetPrice()
    {
      if (Amount >= 3)
      {
        Price = ((Amount / 3) * 5) + ((Amount % 3 ) * 2);
        return Price;
      }
      Price = Amount * 2;
      return Price;
    }
  }
}