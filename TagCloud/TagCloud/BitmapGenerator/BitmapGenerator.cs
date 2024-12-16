using System.Drawing;
using TagCloud.CloudLayouter;

namespace TagCloud.BitmapGenerator;

public class BitmapGenerator(ICloudLayouter layouter, BitmapGeneratorSettings settings) : IBitmapGenerator
{
    public Bitmap GenerateBitmapFromWords(IEnumerable<CloudWord> words)
    {
        var bitmap = new Bitmap(settings.ImageSize.Width, settings.ImageSize.Height);
        using var graphics = Graphics.FromImage(bitmap);

        graphics.Clear(settings.Background);
        var brush = new SolidBrush(settings.WordsColor);

        foreach (var word in words)
        {
            var font = new Font(settings.FontFamily, word.FontSize);
            var size = graphics.MeasureString(word.Word, font);
            var position = layouter.PutNextRectangle(size.ToSize());

            graphics.DrawString(word.Word, font, brush, position);
        }

        return bitmap;
    }
}
