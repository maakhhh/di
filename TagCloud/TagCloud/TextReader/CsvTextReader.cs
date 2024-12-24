using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Globalization;
using TagCloud.SettingsProviders;

namespace TagCloud.TextReader;

public class CsvTextReader : ITextReader
{
    private ISettingsProvider<TextReaderSettings> settingsProvider;

    public CsvTextReader(ISettingsProvider<TextReaderSettings> settingsProvider)
    {
        this.settingsProvider = settingsProvider;
    }

    public string[] GetFormats() => ["csv"];

    public string Read()
    {
        var settings = settingsProvider.GetSettings();
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HasHeaderRecord = true,
        };

        using var reader = new StreamReader(settings.Path);
        using var csv = new CsvReader(reader, config);

        return string.Join('\n', csv.GetRecords<Cell>().Select(c => c.Word));
    }

    private class Cell
    {
        [Index(0)]
        public string Word { get; set; }
    }
}
