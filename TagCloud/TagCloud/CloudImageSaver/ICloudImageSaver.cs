using System.Drawing;

namespace TagCloud.CloudImageSaver;

public interface ICloudImageSaver
{
    public string Save(Bitmap image);
}
