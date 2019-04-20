using System;
using System. Collections.Generic;

namespace Dealership {



public class Program
{
  public static void Main()
  {
    Car porsche = new Car("porsh 312", 1234, 1234);
    Car ford = new Car("ford 5643", 1234, 4556);
    Car lexus = new Car("lexuy23",  8765, 98763);


    List<Car> Cars = new List<Car>() { porsche,ford,lexus };

    lexus.SetPrice(2000);

    Console.WriteLine("Enter maximum price:");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

      List<Car>CarsMatchingSearch = new List <Car>(0);




    foreach (Car automobile in Cars)
    {
      if (automobile.WorthBuying ( maxPrice))
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine("--------------");
      Console.WriteLine(automobile.GetMakeModel());
      Console.WriteLine(automobile.GetMiles() + " miles");
      Console.WriteLine("$" + automobile.GetPrice());
    }
  }
}
}
