using Nagp.Car.Decorators;
using System;

namespace Nagp.Car
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar car = new BmwCar();
            car.CreateCar("BMW");
            Console.WriteLine(car);
            Console.WriteLine(new DieselCarDecorator(car));
            Console.WriteLine(new PetrolCarDecorator(car));

            Console.WriteLine("\n\nEnter any key to exit.");
            Console.ReadKey();
        }
    }
}
