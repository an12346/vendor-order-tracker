using System.Collections.Generic;


namespace VendorOrder.Models 
{

  public class Order
  {
   public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date {get; set; }
    public int Id { get; }

    private static List<Order> _instances = new List<Order> {};

    public Order(string title, string description, int price, string date)
    { 
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      Id = _instances.Count;
      _instances.Add(this);
    }

    public static List<Order> GetAll()
    { 
      return _instances;
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId];
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
  