using Domain.Models;
namespace Infrastructure.Services;

public interface IVehicle
{
      void Drive();
      bool Refuel(int cnt);

}
