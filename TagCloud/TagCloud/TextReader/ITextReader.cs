namespace TagCloud.TextReader;

public interface ITextReader
{
    public string[] GetFormats();
    public string Read();
}
