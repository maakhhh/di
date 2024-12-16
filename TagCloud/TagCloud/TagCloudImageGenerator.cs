using TagCloud.BitmapGenerator;
using TagCloud.CloudImageSaver;
using TagCloud.TextFilters;
using TagCloud.TextReader;

namespace TagCloud;

public class TagCloudImageGenerator(
    ITextReader reader,
    ICloudImageSaver saver,
    IBitmapGenerator bitmapGenerator,
    IEnumerable<ITextFilter> filters)
{
    public string? TagCloudPath { get; private set; }
    private const int MAX_FONTSIZE = 100;
    private const int MIN_FONTSIZE = 8;
    private int maxWordCount;
    private int minWordCount;

    public void GenerateCloud()
    {
        var text = reader.ReadText();

        var wordsFrequency = filters
            .Aggregate(text, (word, filter) => filter.ApplyFilter(word))
            .GroupBy(w => w)
            .OrderByDescending(words => words.Count())
            .ToDictionary(words => words.Key, words => words.Count());

        minWordCount = wordsFrequency.Values.Min();
        maxWordCount = wordsFrequency.Values.Max();

        var words = wordsFrequency
            .Select(w => new CloudWord(w.Key, GetWordFontSize(w.Value)));

        var bitmap = bitmapGenerator.GenerateBitmapFromWords(words);
        TagCloudPath = saver.Save(bitmap);
    }

    private int GetWordFontSize(int freqCount) =>
        MIN_FONTSIZE + (MAX_FONTSIZE - MIN_FONTSIZE) 
        * (freqCount - minWordCount) / (maxWordCount - minWordCount);
}
