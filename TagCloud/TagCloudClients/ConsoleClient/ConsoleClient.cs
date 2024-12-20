using TagCloud;
using TagCloud.BitmapGenerators;
using TagCloud.CloudImageSavers;
using TagCloud.CloudLayouter.PositionGenerator;
using TagCloud.SettingsProviders;
using TagCloud.TextReader;

namespace TagCloudClients.ConsoleClients;

public class ConsoleClient : IClient
{
    private TagCloudImageGenerator generator;
    public ConsoleClient(
        TagCloudImageGenerator generator,
        ISettingsProvider<BitmapGeneratorSettings> bitmapSettings,
        ISettingsProvider<SaveSettings> saveSettings,
        ISettingsProvider<SpiralGeneratorSettings> spiralSettings,
        ISettingsProvider<TextReaderSettings> readerSettings)
    {
        this.generator = generator;
    }

    public void Run()
    {
        // тут получаем настройки и заливаем их в провайдеры
        throw new NotImplementedException();
    }
}
