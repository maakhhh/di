namespace TagCloud.TextFilters;

public interface ITextFilter
{
    public List<string> ApplyFilter(List<string> text);
}
