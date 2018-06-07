using System;
using System.Threading.Tasks;

namespace CS71
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            await Task.Delay(0);

            Console.WriteLine("Press Enter to continue ...");
            Console.ReadLine();
        }
    }
}