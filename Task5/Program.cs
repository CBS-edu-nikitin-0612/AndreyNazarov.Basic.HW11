using System;
using Task4;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Может я задание не так понял, но ни с какми проблемами не столкнулся, может имеется ввиду что хранится все это будет как объект?
            ArrayList arrayList = new();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add("text");
            arrayList.Add(new ArrayList());
            arrayList.Add(new ArrayList());


            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
        }
    }
}
