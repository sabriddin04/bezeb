using Domain.Models;
namespace Infrastructure.Services;

public class Vehicle:IVehicle
{
     public int cnt; 
    public void Drive(){
        if(cnt>0){
            System.Console.WriteLine("Driving");
        }
    }
    public bool Refuel(int cnt){
        cnt++;
        return true;
    }
}
