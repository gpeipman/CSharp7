namespace CS71
{
    public static class DefaultLiteralExpressions
    {
        public static void OldStyle()
        {
            var i = default(int);
            var o = default(object);
        }
        private static int OldMethodWithArgs(int i = default(int), object o = default(object))
        {
            return default(int);
        }

        // Default expressions in declarations
        public static void NewStyle()
        {
            int i = default;
            object o = default;
        }

        // Default expressions in arguments
        private static int NewMethodWithArgs(int i = default, object o = default)
        {
            return default;
        }

        // Generics are supported
        private static T NewMethodWithArgs<T>(int i = default, object o = default)
        {
            return default;
        }
    }
}

