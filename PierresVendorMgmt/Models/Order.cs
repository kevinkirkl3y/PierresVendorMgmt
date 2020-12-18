using System.Collections.Generic;

namespace PierresVendorMgmt.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public int Id { get; set; }
    private static List<Order> _instances = new List<Order>{};

    public Order(string title, string description, int price, string date)
    {
      Title = date;
      Description = description;
      Price = price;
      Date = title;
    }
  }
}