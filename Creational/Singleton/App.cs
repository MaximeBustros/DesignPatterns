public class App : IApp
{
    private readonly IDependencyInjectionDatabase _database;

    public App(IDependencyInjectionDatabase database)
    {
        _database = database;
    }

    public void Run()
    {
        Console.WriteLine(SingletonDatabase.Instance == SingletonDatabase.Instance);
        Console.WriteLine(RecommendedSingletonDatabase.Instance == RecommendedSingletonDatabase.Instance);
        _database.Query("Hello World!");
    }
}
