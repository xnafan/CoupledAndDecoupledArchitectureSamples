namespace ConsoleGui
{
    public static class SuperSimpleIocContainer
    {
        private static Dictionary<Type, Func<object>> _creationFunctions = new Dictionary<Type, Func<object>>();

        public static void Register<T>(Func<T> instantiator) where T : class
        {
            _creationFunctions.Add(typeof(T), instantiator);
        }

        public static T Resolve<T>()
        {
            return (T)_creationFunctions[typeof(T)]();
        }
    }
}
