class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(SingletonDatabase.Instance == SingletonDatabase.Instance);
        Console.WriteLine(RecommendedSingletonDatabase.Instance == RecommendedSingletonDatabase.Instance);
    }
}