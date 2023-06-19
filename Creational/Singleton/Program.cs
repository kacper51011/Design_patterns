using Singleton;

internal class Program
{
    private static void Main(string[] args)
    {
        // Expected behaviour - singleton will be created (console will print "instance created")
        SingletonClass singletonInstance1 = SingletonClass.CreateInstance();

        

        // The expected behaviour is that singletonInstance2 will not be created (console will print "instance already exist"
        SingletonClass singletonInstance2 = SingletonClass.CreateInstance();
        

    }
}