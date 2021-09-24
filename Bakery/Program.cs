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

      string breadStart = Console.ReadLine();
      if (breadStart.ToLower() == "no") {
        Console.WriteLine("Take care then and thanks for coming in!");
      } else if (breadStart.ToLower() == "yes") {
        Console.WriteLine("Fantastic! Let's start with some bread!");
        Console.WriteLine("How many loaves would you like: ");
        string breadOrder = Console.ReadLine();
        int breadAmount = int.Parse(breadOrder);
        Bread freshBread = new Bread(breadAmount);
        freshBread.SetPrice();
        Console.WriteLine($"An order of {breadAmount} will be ${freshBread.Price}!");
        Console.WriteLine("Discounts already applied! Check the math!");
        Console.WriteLine("Now how about some pastries? (yes/no)");
        // Stopped here for the moment
        if (breadAmount == 0) {
          Console.WriteLine("No bread today? How about some pastries then? (yes/no)");
          // string pastryOrder = Console.ReadLine();
          // if (pastryOrder);

        }
      }

    }
  }
}