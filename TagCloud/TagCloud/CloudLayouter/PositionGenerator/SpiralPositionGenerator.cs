using System.Drawing;
using TagCloud.CloudLayouter.PositionGenerator;

namespace TagCloud.CloudLayouter;

public class SpiralPositionGenerator : IPositionGenerator
{
    private readonly SpiralGeneratorSettings settings;

    public SpiralPositionGenerator(SpiralGeneratorSettings settings)
    {
        this.settings = settings;
    }

    public IEnumerable<Point> GetPositions()
    {
        int x, y;
        double radius, angle = 0;

        while (true)
        {
            radius = settings.SpiralStep * angle;
            x = (int)(settings.Center.X + radius * Math.Cos(angle));
            y = (int)(settings.Center.Y + radius * Math.Sin(angle));

            yield return new(x, y);

            angle += settings.AngleOffset;
        }
    }
}
