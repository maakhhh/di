using System.Drawing;

namespace TagCloud.BitmapGenerators;

public record class BitmapGeneratorSettings(
    Size ImageSize,
    Color Background,
    Color WordsColor,
    FontFamily FontFamily);
