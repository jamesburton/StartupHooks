using System.Diagnostics;

class StartupHook
{
    // public static void Initialize() =>
    //     Console.SetOut(new InvertedTextWriter(Console.Out));

    private static Stopwatch _stopwatch = new Stopwatch();
    public static void Initialize() 
    {
        var oldOut = Console.Out;
        Console.WriteLine($"=~= Starting inversion process @ {DateTime.UtcNow:O}");
        Console.SetOut(new InvertedTextWriter(Console.Out));
        _stopwatch.Start();
        AppDomain.CurrentDomain.ProcessExit += (s, e) => {
            _stopwatch.Stop();
            Console.SetOut(oldOut);
            Console.WriteLine($"=~= End of inversion process @ {DateTime.UtcNow:O}");
            Console.WriteLine($"- Interval: {_stopwatch.Elapsed}");
        };
    }
}