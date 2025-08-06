// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.ConstrainedExecution;

namespace VehicleMove;

class Program
{
    static void Main()
    {
        IMovable car = new Car();
        IMovable bike = new Bicycle();

        car.Move();
        bike.Move();
    }
}