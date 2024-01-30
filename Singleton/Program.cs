namespace Singleton;

class Program
{
    static void Main(string[] args)
    {
        var logger = Logger.GetInstance();
        logger.Log("First Log");

        var logger2 = Logger.GetInstance();
        logger2.Log("Second Log");

    }
}

class Logger
{
    private static Logger? _instance;
    private Logger()
    {

    }
    public static Logger GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Logger();
        }
        return _instance;
    }
    public void Log(string message)
    {
        System.Console.WriteLine($"Logging: {message}");
    }
}
