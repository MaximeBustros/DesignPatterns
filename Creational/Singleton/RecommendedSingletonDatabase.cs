public class RecommendedSingletonDatabase
{
    private static readonly Lazy<RecommendedSingletonDatabase> _instance = new(() => {
        return new RecommendedSingletonDatabase();
    });

    private RecommendedSingletonDatabase() { }

    public static RecommendedSingletonDatabase Instance => _instance.Value;
}
