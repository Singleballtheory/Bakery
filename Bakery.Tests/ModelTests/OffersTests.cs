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
  }
}