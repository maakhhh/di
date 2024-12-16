using System.Drawing;

namespace TagCloud.CloudLayouter;

public interface IPositionGenerator
{
    public IEnumerable<Point> GetPositions();
}
