using SingletonThreadSafe;

internal class Program
{
    private static void Main(string[] args)
    {
        // Calling the CreateInstance method in parralel to check if there are unnecessary behaviours
        // Expected: only one instance created
        Parallel.Invoke(new Action(() =>
        {
            SingletonThreadSafeClass singleton1 = SingletonThreadSafeClass.CreateInstance();
            SingletonThreadSafeClass singleton2 = SingletonThreadSafeClass.CreateInstance();
            SingletonThreadSafeClass singleton3 = SingletonThreadSafeClass.CreateInstance();
            SingletonThreadSafeClass singleton4 = SingletonThreadSafeClass.CreateInstance();
        }));
    }
}