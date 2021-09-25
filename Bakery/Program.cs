using System;
using Offers.Models;

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

      string OrderStart = Console.ReadLine();
      if (OrderStart.ToLower() == "no")
      {
        Console.WriteLine("Take care then and thanks for coming in!");
      }
      else if (OrderStart.ToLower() == "yes")
      {
        Console.WriteLine("Fantastic! Let's start with some bread!");
        Console.WriteLine("How many loaves would you like: ");
        string breadOrder = Console.ReadLine();
        int breadAmount = int.Parse(breadOrder);
        Bread freshBread = new Bread(breadAmount);
        freshBread.SetPrice();
        Console.WriteLine("And how many pastries would you like?: ");
        string pastryOrder = Console.ReadLine();
        int pastryAmount = int.Parse(pastryOrder);
        Pastry freshPastry = new Pastry(pastryAmount);
        freshPastry.SetPrice();
        if (breadAmount == 0 && pastryAmount == 0)
        {
          Console.WriteLine("No bread or pastries today? Suit yourself!");
        } else if (breadAmount != 0 || pastryAmount != 0)
        {
        Console.WriteLine($"A bread order of {breadAmount} will be ${freshBread.Price}.");
        Console.WriteLine($"A pastry order of {pastryAmount} will be ${freshPastry.Price}.");
        Console.WriteLine("Discounts already applied. Check the math!");
        Console.WriteLine($"That makes for a grand total of ${(freshBread.Price + freshPastry.Price)}!");
        Console.WriteLine("Thanks for coming in!");
        }
      }
    }
  }
}