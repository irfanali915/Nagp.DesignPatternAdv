namespace Nagp.Car.Decorators
{
    public abstract class CarEngineDecorator : BasicCarWithoutEngine
    {
        protected ICar Car { get; }

        public CarEngineDecorator(ICar car)
        {
            Car = car;
        }

        public override void CreateCar(string name) => Car.CreateCar(name);
    }
}
