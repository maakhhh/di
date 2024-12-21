using WeCantSpell.Hunspell;

namespace TagCloud.TextFilters;

public class BoringTextFilter : ITextFilter
{
    private readonly WordList wordList = WordList.CreateFromFiles(
            "./Dictionaries/en.dic",
            "./Dictionaries/en.aff"
        );

    private readonly string[] boringPo = 
        ["po:pronoun", "po:preposition", "po:determiner", "po:conjunction"];

    public IEnumerable<string> Apply(IEnumerable<string> text) =>
        text.Where(w => !IsBoring(w));

    private bool IsBoring(string word)
    {
        var details = wordList[word];
        if (details != null && details.Length > 0 && details[0].Morphs.Count > 0)
        {
            var po = details[0].Morphs[0];
            return boringPo.Contains(po);
        }

        return false;
    }
}
