using System;
using System.Collections.Generic;

namespace Dealership
{

  public class Program
  {
    public static void Main()
    {
      Car porsche = new Car("2014 Porsche 911", 114991, 7864, "It's probably in the shop.");
      Car ford = new Car("2011 Ford F450", 55995, 14241, "You know what they say about guys with big trucks...");
      Car lexus = new Car("2013 Lexus RX 350", 44700, 20000, "I always wanted one of those.");
      Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979, "Benz there, donz that.");

      List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };

      lexus.SetPrice(2000);

      foreach(Car automobile in Cars)
      {
        Console.WriteLine(automobile.GetMakeModel());
      }

      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      List<Car> CarsMatchingSearch = new List<Car>();

      Console.WriteLine("Enter maximum mileage: ");
      string stringMaxMileage = Console.ReadLine();
      int maxMileage = int.Parse(stringMaxMileage);


      foreach (Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice, maxMileage))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }

      if (CarsMatchingSearch.Count == 0)
      {
          Console.WriteLine("No cars matched your search");
      }
      else
      {
        foreach(Car automobile in CarsMatchingSearch)
        {
          automobile.DisplayInfo();
        }
      }
    }
  }
}
