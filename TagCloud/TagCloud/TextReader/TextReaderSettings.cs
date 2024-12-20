using System.Text;

namespace TagCloud.TextReader;

public record class TextReaderSettings
{
    public string Path { get; private set; } = "input.txt";
    public Encoding Encoding { get; private set; } = Encoding.UTF8;

    public TextReaderSettings() { }

    public TextReaderSettings(string path, Encoding encoding)
    {
        Path = path;
        Encoding = encoding;
    }
}
