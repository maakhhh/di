using System.Drawing;

namespace TagCloud.CloudImageSaver;

public class CloudImageSaver(SaveSettings settings) : ICloudImageSaver
{
    public string Save(Bitmap image)
    {
        var filename = $"{settings.Filename}.{settings.Format.ToString().ToLower()}";
        image.Save(filename);
        return Path.Combine(Directory.GetCurrentDirectory(), filename);
    }
}
