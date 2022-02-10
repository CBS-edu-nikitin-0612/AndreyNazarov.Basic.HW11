using System;
using Task4;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add("text");
            arrayList.Add(new Random());
            arrayList.Add(new Random());

            for (int i = 0; i < arrayList.Count; i++)
            {
                if(arrayList[i] is Random )
                {
                    Console.WriteLine("Random - " + ((Random)arrayList[i]).Next());
                }
                if (arrayList[i] is Int32)
                {
                    Console.WriteLine("Int32 - " + ((Int32)arrayList[i]));
                }
            }
        }
    }
}
