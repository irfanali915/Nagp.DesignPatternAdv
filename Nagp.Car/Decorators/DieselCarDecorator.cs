namespace Nagp.Car.Decorators
{
    public class DieselCarDecorator : CarEngineDecorator
    {
        public DieselCarDecorator(ICar car) : base(car)
        {
            EngineType = "Diesel";
            System.Console.WriteLine("---------------------- Engine Decorated by DieselCarDecorator ----------------------");
        }
    }
}
