using System;

namespace CSharp7
{
    // BC
    public static class OutVarsSample
    {
        public static void Classic()
        {
            var intString = "123";
            var i = 0;

            if(int.TryParse(intString, out i))
            {
                Console.WriteLine("i is integer");
            }
            else 
            {
                Console.WriteLine("i is not integer");
            }
        }

        public static void OutInt()
        {
            var intString = "123";

            if (int.TryParse(intString, out int i))
            {
                Console.WriteLine("i is integer");
            }
            else
            {
                Console.WriteLine("i is not integer");
            }
        }

        public static void OutVar()
        {
            var intString = "123";

            if (int.TryParse(intString, out var i))
            {
                Console.WriteLine("i is integer");
            }
            else
            {
                Console.WriteLine("i is not integer");
            }
        }

        public static void SkipVar()
        {
            var intString = "123";

            if (int.TryParse(intString, out _))
            {
                Console.WriteLine("i is integer");
            }
            else
            {
                Console.WriteLine("i is not integer");
            }
        }
    }
}
