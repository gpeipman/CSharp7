namespace CS72
{
    public class PrivateInternalExample
    {
        protected internal void Dummy()
        {
        }
    }         

    public class DemoOfPrivateInternal
    {
        public void Demo()
        {
            var x = new PrivateInternalExample();
            x.Dummy();
        }
    }

    public class PrivateProtectedExample
    {
        protected private void Dummy()
        {
        }

    }
    public class DemoOfPrivateProtected2 : PrivateProtectedExample
    {
        public void Demo()
        {
            Dummy();
        }
    }

    public class DemoOfPrivateProtected
    {
        public void Demo()
        {
            var x = new PrivateProtectedExample();
            x.Dummy();
        }
    }
    
}



