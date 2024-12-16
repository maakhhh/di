using System.Drawing;

namespace TagCloud.BitmapGenerator;

public record class BitmapGeneratorSettings(
    Size ImageSize,
    Color Background,
    Color WordsColor,
    FontFamily FontFamily);
