namespace Nagp.Car.Decorators
{
    public class PetrolCarDecorator : CarEngineDecorator
    {
        public PetrolCarDecorator(ICar car) : base(car)
        {
            EngineType = "Petrol";
            System.Console.WriteLine("---------------------- Engine Decorated by PetrolCarDecorator ----------------------");
        }
    }
}
