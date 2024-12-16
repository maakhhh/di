using System.Drawing;

namespace TagCloud.BitmapGenerators;

public interface IBitmapGenerator
{
    public Bitmap GenerateBitmapFromWords(IEnumerable<CloudWord> words);
}
