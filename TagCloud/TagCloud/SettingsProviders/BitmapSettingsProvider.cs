using TagCloud.BitmapGenerators;

namespace TagCloud.SettingsProviders;

public class BitmapSettingsProvider : ISettingsProvider<BitmapGeneratorSettings>
{
    private BitmapGeneratorSettings settings = new();

    public BitmapGeneratorSettings GetSettings() => settings;

    public void SetSettings(BitmapGeneratorSettings settings)
    {
        this.settings = settings;
    }
}
