using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstancesOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Susie's Bakery", "Bakery");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetNameOfVendor_ReturnsNameOfVendor_String()
    {
      string name = "Susie's Bakery";
      Vendor newVendor = new Vendor(name, "Bakery");
      string output = newVendor.Name;
      Assert.AreEqual(name, output);
    }


    [TestMethod]
    public void GetDescriptionOfVendor_ReturnsDescriptionOfVendor_String()
    {
      string description = "Bakery";
      Vendor newVendor = new Vendor("Susie's Bakery", description);
      string output = newVendor.Description;
      Assert.AreEqual(description, output);
    }
    

    [TestMethod]
    public void GetId_ReturnsTheIdOfVendor_Int()
    {
      string name = "Susie's Bakery";
      string description = "Bakery";
      Vendor  newVendor = new Vendor(name, description);
      int output = newVendor.Id;
      Assert.AreEqual(0, output);
    }
    
  }
}