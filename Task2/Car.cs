using System;

namespace Task2
{
    internal class Car
    {
        public string Name { get; private set; }
        private DateTime yearOfManufacture;
        public int YearOfManufacture { get => yearOfManufacture.Year; }

        public Car(string name, string yearOfManufacture)
        {
            Name = name;
            try
            {
                this.yearOfManufacture = DateTime.Parse(yearOfManufacture);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name} Year: {YearOfManufacture}");
        }
    }
}
