namespace Nagp.Car
{
    public class BmwCar : BasicCarWithoutEngine
    {
        public override string EngineType { get; set; }

        public override void CreateCar(string name)
        {
            Name = name;
            Manufacture = "BMW";
            EngineType = "Use decorators to decorate Car engine.";
        }
    }
}
