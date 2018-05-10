namespace CS70
{
    public class RefSample
    {
        static ref int FindFirstNegativeNumber(int[] numbers, ref int notFoundValue)
        {
            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    return ref numbers[i];
                }
            }

            return ref notFoundValue;
        }

        static void RefLocals()
        {
            var numbers = new[] { 1, 2, -4, 6, -8 };
            var returnValue = 0;

            ref var result = ref FindFirstNegativeNumber(numbers, ref returnValue);
            result++;
        }
    }
}
