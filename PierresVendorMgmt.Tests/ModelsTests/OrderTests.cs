using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendorMgmt.Models;
using System.Collections.Generic;
using System;
namespace PierresVendorMgmt.Tests
{
  [TestClass]
  public class OrderTest
  {
    [TestMethod]
    public void Order_CorrectlyCreatesAnInstanceOfAnOrder_Order()
    {
      Order newOrder = new Order();
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void OrderConstructor_CorrectlyReturnsPropertiesOfOrder_Properties()
    {
      string name = "Test";
      string description = "Test";
      int price = 1;
      string date = "12.18.2020";
      Order newOrder = new Order(name, description, price, date);
      Assert.AreEqual(name, newOrder.Name);
      Assert.AreEqual(description, newOrder.Description);
      Assert.AreEqual(price, newOrder.Price);
      Assert.AreEqual(date, newOrder.Date);
    }

  }
}