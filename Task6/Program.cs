using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<Random> myClass = new();

            var rnd = myClass.FactoryMethod();

            Console.WriteLine(rnd.Next());
        }
    }
}
