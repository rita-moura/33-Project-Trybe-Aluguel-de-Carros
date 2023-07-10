namespace RentCars.Types;

//9 - Crie um enum `RentStatus`
public enum RentStatus
{
  Confirmed = 0,
  Finished = 1,
  Canceled = Finished,
}