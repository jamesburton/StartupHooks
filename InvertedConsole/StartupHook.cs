class StartupHook
{
    public static void Initialize() =>
        Console.SetOut(new InvertedTextWriter(Console.Out));
}