using RentCars.Types;
namespace RentCars.Models;

//8 - Faça a classe `PickupTruck` herdar de `Car`
public class PickupTruck : Car
{
    public double LoadCapacity {get; set;}
}