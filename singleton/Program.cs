using System.Diagnostics.Metrics;

public sealed class Singleton
{
    public static int counter = 6;

    // The constructor is kept private so that we cannot access it from outside the class. Hence instance wont be created.
    private Singleton() {}

    // This variable is gonna store the Instance of Singleton class.
    private static Singleton Instance = null;

    // Gives us the same instance else creates new if not present.
    public static Singleton GetInstance()
    {
        if (Instance == null)
        {
            counter++;
            Instance = new Singleton(); 
            Console.WriteLine(counter.ToString());
        }
        return Instance;
    }

    public void PrintDetails(string message)
    {
        Console.WriteLine("Printing from " + message);
    }

}

class Program
{
    public static void Main(string[] args)
    {
        /* Even if we create two objects or instances it will still create an instance only once.
           Rest all times it will return the same or already created instance. */
        Singleton instance = Singleton.GetInstance();
        instance.PrintDetails("Held");

        Singleton instance2 = Singleton.GetInstance();
        instance2.PrintDetails("Sold");

    }
}