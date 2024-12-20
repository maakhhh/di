using System.Drawing;
using TagCloud.SettingsProviders;

namespace TagCloud.CloudImageSavers;

public class CloudImageSaver(ISettingsProvider<SaveSettings> settingsProvider) : ICloudImageSaver
{
    public string Save(Bitmap image)
    {
        var settings = settingsProvider.GetSettings();
        var filename = $"{settings.FileName}.{settings.Format.ToString().ToLower()}";
        image.Save(filename);
        return Path.Combine(Directory.GetCurrentDirectory(), filename);
    }
}
