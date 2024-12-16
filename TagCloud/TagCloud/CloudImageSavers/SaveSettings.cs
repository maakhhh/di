namespace TagCloud.CloudImageSavers;

public record class SaveSettings(string Filename, ImageFormat Format);

public enum ImageFormat
{
    PNG,
    JPEG,
    JPG
}
