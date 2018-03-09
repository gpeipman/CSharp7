using System;

namespace CSharp7
{
    public static class LocalFunctionsSample
    {
        public static void PrintFactorial(int i)
        {
            Console.WriteLine(i + "! = " + Factorial(i));

            int Factorial(int n)
            {
                var result = n;

                for (var counter = n - 1; counter >= 1; counter--)
                {
                    result = result * counter;
                }

                return result;
            }
        }
    }
}
