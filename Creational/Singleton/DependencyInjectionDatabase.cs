public class DependencyInjectionDatabase : IDependencyInjectionDatabase
{
    public DependencyInjectionDatabase()
    {
        Console.WriteLine("Database intentiated");
    }

    public void Query(string queryString)
    {
        Console.WriteLine($"Queried: {queryString}");
    }
}