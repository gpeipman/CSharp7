using System;

namespace CS70
{
    class Program
    {
        static void Main(string[] args)
        {
            var storeSample = new TupleLiteralsSample();
            var storeWithDistance = storeSample.GetNearestStore(100, 100);
            Console.WriteLine("Hello World!");
        }
    }
}
