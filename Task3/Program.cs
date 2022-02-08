using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new();
            dict.Add("первый", "first");
            dict.Add("второй", "second");
            dict.Add("третий", "third");
            dict.Add("четвертый", "fourth");
            dict.Add("пятый", "fifth");

            Console.WriteLine(dict.Count);
            Console.WriteLine(dict[1].Key);
            Console.WriteLine(dict[2].Value);
        }
    }
}
