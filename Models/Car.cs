using System;

namespace Dealership
{

  class Car
  {
    private string MakeModel;
    private int Price;
    private int Miles;
    private string Note;

    public Car(string makeModel, int price, int miles, string note)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Note = note;
    }

    public string GetNote()
    {
      return Note;
    }

    public string GetMakeModel()
    {
      return MakeModel;
    }

    public int GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    public void SetNote(string newNote)
    {
      Note = newNote;
    }

    public bool WorthBuying(int maxPrice, int maxMileage)
    {
      return (Price < maxPrice && Miles <= maxMileage);
    }
  }
}
