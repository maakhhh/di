using TagCloud.CloudLayouter.PositionGenerator;

namespace TagCloud.SettingsProviders;

public class SpiralGeneratorSettingsProvider : ISettingsProvider<SpiralGeneratorSettings>
{
    private SpiralGeneratorSettings settings = new();

    public SpiralGeneratorSettings GetSettings() => settings;

    public void SetSettings(SpiralGeneratorSettings settings)
    {
        this.settings = settings;
    }
}
