namespace TagCloud.TextSplitters;

public interface ITextSplitter
{
    public IEnumerable<string> Split(string text);
}
