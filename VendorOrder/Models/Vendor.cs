using System.Collections.Generic;


namespace VendorOrder.Models
{
  public class Vendor
  {
    public string Name { get; set; }

    public string Description { get; set; }

    public int Id { get; }

    public List<Order> Orders { get; set; }

    private static List<Vendor> _instances = new List<Vendor> {};

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      Orders = new List<Order>{};
      Id = _instances.Count;
      _instances.Add(this);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId];
    }

    public static List<Vendor> GetAll()
    { 
      return _instances;
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

  }

}

//Create vendor class 
  //-vendor's name
  //-description of vendor 
  //-list of orders -- connected to Order class

