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
      //VendorTests.ClearAll();
    }
    [TestMethod]
    public void Vendor_CorrectlyCreatesAnInstanceOfAnOrder_Order()
    {
      Vendor newVendor = new Vendor();
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
  }
}