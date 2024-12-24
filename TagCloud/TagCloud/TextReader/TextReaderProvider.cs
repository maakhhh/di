using TagCloud.SettingsProviders;

namespace TagCloud.TextReader;

public class TextReaderProvider
{
    private readonly ISettingsProvider<TextReaderSettings> settingsProvider;
    private readonly IEnumerable<ITextReader> readers;

    public TextReaderProvider(
        ISettingsProvider<TextReaderSettings> settingsProvider,
        IEnumerable<ITextReader> readers)
    {
        this.settingsProvider = settingsProvider;
        this.readers = readers;
    }

    public ITextReader GetActualReader()
    {
        var path = settingsProvider.GetSettings().Path;
        var splittedPath = path.Split('.');
        if (splittedPath.Length < 2)
            throw new ArgumentException($"Указан неверный путь до входного файла: {path}");

        var format = splittedPath.Last();

        var reader = readers.Where(r => r.GetFormats().Contains(format.ToLower())).FirstOrDefault();

        if (reader == null)
            throw new ArgumentException($"Данный формат файла не поддерживается: {format}");

        return reader;
    }
}
