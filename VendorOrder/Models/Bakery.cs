using System.Collections.Generic;
using System;

namespace Bakery.Models
{ 
  public class Bread
  {
    public int Amount {get; set;}

    public Bread(int amount)
    {
      Amount = amount;
    }
    
    public int CalBreadPrice(int amount) 
    {
      int breadPrice = 5;
      int totalBreadPrice = 0;
      
      if (amount == 1)
      {
        return totalBreadPrice += 5;
      }
      else if (amount == 2 || amount == 3) 
      {
        return totalBreadPrice += 10;
      }
      else
      {
        totalBreadPrice = (amount * breadPrice) - ((amount/3) * breadPrice);
        return totalBreadPrice;
      }
    }
  }
  public class Pastry
  {
    public int Amount {get; set;}
    public Pastry(int amount)
    {
      Amount = amount;
    }
    public int CalPastryPrice(int amount)
    {
      int pastryPrice = 2;
      int totalPastryPrice = 0;
      
      if (amount == 1)
      {
        return totalPastryPrice += 2;
      }
      if (amount == 3)
      {
        return totalPastryPrice += 5;
      }
      else if (amount == 4)
      {
        return totalPastryPrice += 7;
      }
      else if (amount == 5)
      {
        return totalPastryPrice += 9;
      }
      else if (amount == 6)
      {
        return totalPastryPrice += 10;
      }
      else {
        totalPastryPrice = amount * pastryPrice;
        return totalPastryPrice;
      }
    }
  }
}
