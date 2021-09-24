using System;
using Offers.Models;
// using System.Text.RegularExpressions;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.Clear();

      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("We've got bread loaves for $5 each, or Buy Two Get 1 Free!");
      Console.WriteLine("We also have fresh pastries for $2 each, or Three for $5!");
      Console.WriteLine("Care to place an order? (yes/no)");

      string takeOrder = Console.ReadLine();
      if (takeOrder == "no" || takeOrder == "No") {
        Console.WriteLine("Take care then and thanks for coming in!");
      }

    }
  }
}