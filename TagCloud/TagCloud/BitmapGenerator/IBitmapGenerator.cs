using System.Drawing;

namespace TagCloud.BitmapGenerator;

public interface IBitmapGenerator
{
    public Bitmap GenerateBitmapFromWords(IEnumerable<CloudWord> words);
}
