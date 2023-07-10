using RentCars.Types;
namespace RentCars.Models;

//3 - Crie a classe `Vehicle`
public class Vehicle
{
  public string Brand {get; set;} = "";
  public string Model {get; set;} = "";
  public decimal Price {get; set;}
  public FuelType Fuel {get; set;}
  public int EngineCapacity {get; set;}
  public Color MainColor {get; set;}
  public int Year {get; set;}
  public double PricePerDay {get; set;}
  public bool IsRented {get; set;} = false;
}