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

        public static void NewStyle()
        {
            int i = default;
            object o = default;
        }

        private static int NewMethodWithArgs(int i = default, object o = default)
        {
            return default;
        }

        private static T NewMethodWithArgs<T>(int i = default, object o = default)
        {
            return default;
        }
    }
}
