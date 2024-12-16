using System.Drawing;

namespace TagCloud.CloudLayouter;

public interface ICloudLayouter
{
    public List<Rectangle> GetRectangles();
    public Rectangle PutNextRectangle(Size rectangleSize);
}
