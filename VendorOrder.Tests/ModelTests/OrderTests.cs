using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;


namespace VendorOrder.Tests
{

[TestClass]
public class OrderTests
  {
  
    [TestMethod]
    public void OrderConstructor_CreatesInstancesOfOrder_Order()
    {
      Order newOrder = new Order("Susie's Bakery", "pastry", 10, "monday");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}