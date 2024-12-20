namespace TagCloud.TextFilters;

public interface ITextFilter
{
    public IEnumerable<string> Apply(IEnumerable<string> text);
}
