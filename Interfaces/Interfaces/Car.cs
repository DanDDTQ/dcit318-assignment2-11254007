using System;

namespace VehicleMove;

class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}
