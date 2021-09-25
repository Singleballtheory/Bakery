using Microsoft.VisualStudio.TestTools.UnitTesting;
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
      int breadAmount = 3;
      Bread newBread = new Bread(breadAmount);
      newBread.SetPrice();
      Assert.AreEqual(10, newBread.SetPrice());
    }
    [TestMethod]
    public void PastryDeal_SetPrice_Int()
    {
      int pastryAmount = 3;
      Pastry newPastry = new Pastry(pastryAmount);
      newPastry.SetPrice();
      Assert.AreEqual(5, newPastry.SetPrice());
    }
    [TestMethod]
    public void BreadDealPlusTwo_SetPrice_Int()
    {
      int breadAmount = 5;
      Bread newBread = new Bread(breadAmount);
      newBread.SetPrice();
      Assert.AreEqual(20, newBread.SetPrice());
    }
    [TestMethod]
    public void TwoBreadDeals_SetPrice_Int()
    {
      int breadAmount = 6;
      Bread newBread = new Bread(breadAmount);
      newBread.SetPrice();
      Assert.AreEqual(20, newBread.SetPrice());
    }
    [TestMethod]
    public void PastryDealPlusTwo_SetPrice_Int()
    {
      int pastryAmount = 5;
      Pastry newPastry = new Pastry(pastryAmount);
      newPastry.SetPrice();
      Assert.AreEqual(9, newPastry.SetPrice());
    }
    [TestMethod]
    public void TwoPastryDeals_SetPrice_Int()
    {
      int pastryAmount = 6;
      Pastry newPastry = new Pastry(pastryAmount);
      newPastry.SetPrice();
      Assert.AreEqual(10, newPastry.SetPrice());
    }
  }
}