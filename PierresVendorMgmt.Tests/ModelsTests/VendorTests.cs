using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendorMgmt.Models;
using System.Collections.Generic;
using System;
namespace PierresVendorMgmt.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void Vendor_CorrectlyCreatesAnInstanceOfAnOrder_Order()
    {
      Vendor newVendor = new Vendor("Test", "Test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void VendorConstructor_CorrectlyReturnsPropertiesOfVendors_VendorProperties()
    {
      string name = "Suzies Cafe";
      string description = "Small Cafe";
      Vendor newVendor = new Vendor(name, description);
      Assert.AreEqual(name, newVendor.Name);
      Assert.AreEqual(description, newVendor.Description);
    }
    [TestMethod]
    public void GetId_ReturnsCorrectIdOfVendor_Id()
    {
    Vendor newVendor = new Vendor("Test", "Test");
    int result = newVendor.Id;
    Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorInstances_VendorList()
    {
      Vendor vendor1 = new Vendor("test1", "test1");
      Vendor vendor2 = new Vendor("test2", "test2");
      List<Vendor> newList = new List<Vendor>{vendor1, vendor2};
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      Vendor vendor1 = new Vendor("test1", "test1");
      Vendor vendor2 = new Vendor("test2", "test2");
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(vendor2, result);
    }
    [TestMethod]
    public void AddOrder_AssociatesOrdersWithVendors_OrderList()
    {
      Order newOrder = new Order("This", "Is", 4, "test");
      List<Order> orderList = new List<Order> {newOrder};
      Vendor newVendor = new Vendor("Test", "Test");
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(orderList, result);
    }
  }
}