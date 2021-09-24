using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery;
using Offers.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class OffersTests
  {
    [TestMethod]
    public void BreadOrder_OrderOneBread_Bread()
    {
      Bread freshBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), freshBread.GetType());
    }
    [TestMethod]
    public void PastryOrder_OrderOnePastry_Pastry()
    {
      Pastry freshPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), freshPastry.GetType());
    }
    [TestMethod]
    public void BreadPrice_SetPrice_Int()
    {
      int breadAmount = 1;
      Bread newBread = new Bread(breadAmount);
      newBread.SetPrice();
      Assert.AreEqual(5, newBread.SetPrice());
    }
    [TestMethod]
    public void PastryPrice_SetPrice_Int()
    {
      int pastryAmount = 1;
      Pastry newPastry = new Pastry(pastryAmount);
      newPastry.SetPrice();
      Assert.AreEqual(2, newPastry.SetPrice());
    }
    [TestMethod]
    public void BreadDeal_SetPrice_Int()
    {
      int breadAmount = 2;
      Bread newBread = new Bread(breadAmount);
      newBread.SetPrice();
      Assert.AreEqual(10, newBread.SetPrice());

      // User buys two bread and gets one free so price is still 10
    }
  }
}