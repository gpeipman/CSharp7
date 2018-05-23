namespace CS72
{
    public class NonTrailingNamedArguments
    {
        public void Demo()
        {
            var v = 0;

            v = Volume(a: 3, c: 5, b: 4);
            v = Volume(a: 3, 4, 5);
            v = Volume(3, b: 4, 5);

            //v = Volume(3, c: 4, 5);
        }

        public int Volume(int a, int b, int c)
        {
            return a * b * c;
        }
    }
}
