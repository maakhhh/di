using TagCloud.CloudImageSavers;

namespace TagCloud.SettingsProviders;

public class SaveSettingsProvider : ISettingsProvider<SaveSettings>
{
    private SaveSettings settings = new();

    public SaveSettings GetSettings() => settings;

    public void SetSettings(SaveSettings settings)
    {
        this.settings = settings;
    }
}
