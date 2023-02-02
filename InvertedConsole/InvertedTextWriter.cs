using System.Text;

public class InvertedTextWriter : TextWriter
{
    private readonly TextWriter _writer;

    public InvertedTextWriter(TextWriter baseTextWriter)
    {
        _writer = baseTextWriter;
    }

    public override Encoding Encoding => _writer.Encoding;

    public override void Write(string value)
    {
        _writer.Write(string.Concat(value.Reverse()));
    }
}