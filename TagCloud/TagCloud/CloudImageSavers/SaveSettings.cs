using System.Drawing.Imaging;

namespace TagCloud.CloudImageSavers;

public record SaveSettings
{
    public string FileName { get; private set; } = "output";
    public ImageFormat Format { get; private set; } = ImageFormat.Png;

    public SaveSettings() { }

    public SaveSettings(string fileName, ImageFormat format)
    {
        FileName = fileName;
        Format = format;
    }
}
