using TagCloud.TextReader;

namespace TagCloud.SettingsProviders;

public class TextReaderSettingsProvider : ISettingsProvider<TextReaderSettings>
{
    private TextReaderSettings settings = new();

    public TextReaderSettings GetSettings() => settings;

    public void SetSettings(TextReaderSettings settings)
    {
        this.settings = settings;
    }
}
