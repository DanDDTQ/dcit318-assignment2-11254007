// See https://aka.ms/new-console-template for more information
using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main()
        {
            Animal a = new Animal();
            Animal d = new Dog();
            Animal c = new Cat();

            a.MakeSound();
            d.MakeSound();
            c.MakeSound();
        }
    }
}