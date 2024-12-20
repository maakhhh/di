using System.Drawing;

namespace TagCloud.BitmapGenerators;

public record BitmapGeneratorSettings
{
    public Size ImageSize { get; private set; } = new Size(1080, 1920);
    public Color BackgroundColor { get; private set; } = Color.White;
    public Color WordColor { get; private set; } = Color.Black;
    public FontFamily FontFamily { get; private set; } = new FontFamily("Arial");

    public BitmapGeneratorSettings() { }

    public BitmapGeneratorSettings(
        Size imageSize,
        Color backgroudColor,
        Color wordColor,
        FontFamily fontFamily)
    {
        ImageSize = imageSize;
        BackgroundColor = backgroudColor;
        WordColor = wordColor;
        FontFamily = fontFamily;
    }
}
