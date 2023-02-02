using System.Diagnostics;

class StartupHook
{
    private static Stopwatch _stopwatch = new Stopwatch();
    public static void Initialize() 
    {
        Console.WriteLine($"=~= Starting process @ {DateTime.UtcNow:O}");
        _stopwatch.Start();
        AppDomain.CurrentDomain.ProcessExit += (s, e) => {
            _stopwatch.Stop();
            Console.WriteLine($"=~= End of process @ {DateTime.UtcNow:O}");
            Console.WriteLine($"- Duration: {_stopwatch.Elapsed}");
        };
    }
}