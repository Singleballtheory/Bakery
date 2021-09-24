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
  }
}