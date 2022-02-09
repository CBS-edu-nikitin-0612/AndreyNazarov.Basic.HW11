using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("text");
            arrayList.Add(new ArrayList());
            arrayList.Add(new object());

            Console.WriteLine(arrayList[0]);
            Console.WriteLine(arrayList[1]);
            Console.WriteLine(arrayList[2]);
            Console.WriteLine(arrayList[3]);
        }
    }
}
