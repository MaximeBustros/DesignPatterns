using System.Reflection;
using System.Security.Cryptography.X509Certificates;

class SingletonDatabase
{
    private static SingletonDatabase? _instance;
    private static readonly object _lock = new();

    private SingletonDatabase() { }

    public static SingletonDatabase Instance
    {
        get
        {
            if (_instance is null)
            {
                lock (_lock)
                {
                    if (_instance is null)
                    {
                        _instance = new SingletonDatabase();
                    }
                }
            }
            return _instance;
        }
    }
}