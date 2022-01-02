namespace Nagp.Car
{
    public abstract class BasicCarWithoutEngine : ICar
    {

        public string Name { get; protected set; } = "Basic x";

        public virtual string Manufacture { get; protected set; } = "Basic";

        public string BodyType { get; protected set; } = "Basic y";

        public virtual string EngineType { get; set; } = "Basic";

        public int Wheels => 4;

        public int Doors { get; set; } = 4;

        public int SeatingCapacity { get; set; } = 4;

        public abstract void CreateCar(string name);

        public override string ToString()
        {
            return $"Name: {Name}\nManufacture: {Manufacture}\nBodyType: {BodyType}\nEngineType: {EngineType}\nWheels: {Wheels}\nDoors: {Doors}\nSeatingCapacity: {SeatingCapacity}";
        }
    }
}
