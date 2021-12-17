using System.Collections.Generic;
using System;

namespace VendorOrder.Models 
{

  public class Order
  {
    string Title { get; set; }
    string Description { get; set; }
    int Price { get; set; }
    string Date {get; set; }

    private static List<Order> _instances = new List<Order> {};

    public Order(string title, string description, int price, string date)
    { 
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
    }

    public static List<Order> GetAll()
    { 
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }

}



//Create Order class 
  //-title 
  //-description
  //-price of order
  //-date of order

  //title = Who the order is for 
  //description = what they are ordering 
  