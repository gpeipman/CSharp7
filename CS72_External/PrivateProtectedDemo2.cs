using CS72;

namespace CS72_External
{
    class PrivateProtectedDemo2
    {
        public void Demo()
        {
            var x = new PrivateProtectedExample();
            //x.Dummy();
        }
    }
    
    class PrivateProtectedDemo3 : PrivateProtectedExample
    {
        public void Demo()
        {
            //this.Dummy();
        }
    }
}
