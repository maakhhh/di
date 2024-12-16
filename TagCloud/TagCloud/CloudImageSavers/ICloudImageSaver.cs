using System.Drawing;

namespace TagCloud.CloudImageSavers;

public interface ICloudImageSaver
{
    public string Save(Bitmap image);
}
