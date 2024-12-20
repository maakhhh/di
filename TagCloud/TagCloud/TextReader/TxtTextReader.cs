using TagCloud.SettingsProviders;

namespace TagCloud.TextReader;

public class TxtTextReader(ISettingsProvider<TextReaderSettings> settingsProvider) : ITextReader
{
    public IEnumerable<string> Read()
    {
        var settings = settingsProvider.GetSettings();
        return File.ReadLines(settings.Path, settings.Encoding);
    }
}
