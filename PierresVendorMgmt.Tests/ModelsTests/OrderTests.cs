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
      Order newOrder = new Order("test", "test", 1, "test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void OrderConstructor_CorrectlyReturnsPropertiesOfOrder_Properties()
    {
      string title = "Test";
      string description = "Test";
      int price = 1;
      string date = "12.18.2020";
      Order newOrder = new Order(title, description, price, date);
      Assert.AreEqual(title, newOrder.Title);
      Assert.AreEqual(description, newOrder.Description);
      Assert.AreEqual(price, newOrder.Price);
      Assert.AreEqual(date, newOrder.Date);
    }
    [TestMethod]
    public void OrderConstructor_CorrectlyUpdatesProperiesOfOrder_UpdatedProperties()
    {
      Order newOrder = new Order("This", "Is", 4, "test");
      string updatedTitle = "Not";
      newOrder.Title = updatedTitle;
      string updatedDescription = "A";
      newOrder.Description = updatedDescription;
      int updatedPrice = 10;
      newOrder.Price = updatedPrice;
      string updatedDate = "Spared";
      newOrder.Date = updatedDate;
      Assert.AreEqual(updatedTitle, newOrder.Title);
      Assert.AreEqual(updatedDescription, newOrder.Description);
      Assert.AreEqual(updatedPrice, newOrder.Price);
      Assert.AreEqual(updatedDate, newOrder.Date);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

  }
}