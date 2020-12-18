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
    public static void Order_CorrectlyCreatesAnInstanceOfAnOrder_Order()
    {
      Order newOrder = new Order();
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}