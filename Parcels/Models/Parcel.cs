using System.Collections.Generic;

namespace Shipping.Models
{
  public class Parcel
  {
    public static double Width { get; set; }
    public static double Height { get; set; }
    public static double Weight { get; set; }

    public Parcel (double width, double height, double weight)
    {
      Width = width;
      Height = height;
      Weight = weight;
    }

    public static double Volume()
    {
      double dimensions = Width * Height;
      return dimensions;
    }

    public static double CostToShip()
    {
      double cost;
      if (Weight > 0 && Weight <= 5.00)
      {
        cost = 3.00;
      } 
      else if (Weight > 5.01 && Weight <= 15.00)
      {
        cost = 9.00;
      }
      else 
      {
        cost = 15.00;
      }
      return cost;
    }
  }
}