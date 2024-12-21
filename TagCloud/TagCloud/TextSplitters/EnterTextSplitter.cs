namespace TagCloud.TextSplitters;

public class EnterTextSplitter : ITextSplitter
{
    private const char SPLIT_CHAR = '\n';
    public IEnumerable<string> Split(string text)
    {
        return text.Split(SPLIT_CHAR).Select(w => w.Trim()).Where(w => w != string.Empty);
    }
}
