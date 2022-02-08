namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> carCollection = new();
            carCollection.Add(new Car("Volga", "2000.01.01"));
            carCollection.Add(new Car("Volvo", "1990.01.01"));
            carCollection.Add(new Car("Jeep", "2001.01.01"));
            carCollection.Add(new Car("Tesla", "1999.01.01"));

            carCollection[2].PrintInfo();
        }
    }
}
