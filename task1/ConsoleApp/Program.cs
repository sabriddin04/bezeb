using Domain.Models;
using Infrastructure.Services;

var car=new Car(1);
var Vehicle=new Vehicle();
System.Console.WriteLine(Vehicle.Refuel(100));
Vehicle.cnt=100;
Vehicle.Drive();