using System.Collections.Generic;


namespace VendorOrder.Models
{
  public class Vendor
  {
    public string Name { get; set; }

    public string Description { get; set; }

    public List<Order> Orders { get; set; }

    private static List<Vendor> _instances = new List<Vendor> {};

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      Orders = new List<Order>{};
      _instances.Add(this);
    }


  }

}

//Create vendor class 
  //-vendor's name
  //-description of vendor 
  //-list of orders -- connected to Order class

