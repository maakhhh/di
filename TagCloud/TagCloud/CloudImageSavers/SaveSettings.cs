namespace TagCloud.CloudImageSavers;

public record SaveSettings
{
    public string FileName { get; private set; } = "output";
    public ImageFormat Format { get; private set; } = ImageFormat.PNG;

    public SaveSettings() { }

    public SaveSettings(string fileName, ImageFormat format)
    {
        FileName = fileName;
        Format = format;
    }
}

public enum ImageFormat
{
    PNG,
    JPEG,
    JPG
}
