﻿using System.Drawing;
using TagCloud.CloudLayouter;
using TagCloud.SettingsProviders;

namespace TagCloud.BitmapGenerators;

public class BitmapGenerator(
    ICloudLayouter layouter, ISettingsProvider<BitmapGeneratorSettings> settingsProvider) : IBitmapGenerator
{
    public Bitmap GenerateBitmapFromWords(IEnumerable<CloudWord> words)
    {
        var settings = settingsProvider.GetSettings();
        var bitmap = new Bitmap(settings.ImageSize.Width, settings.ImageSize.Height);
        using var graphics = Graphics.FromImage(bitmap);

        graphics.Clear(settings.BackgroundColor);
        using var brush = new SolidBrush(settings.WordColor);

        foreach (var word in words)
        {
            using var font = new Font(settings.FontFamily, word.FontSize);
            var size = graphics.MeasureString(word.Word, font);
            var position = layouter.PutNextRectangle(size.ToSize());

            graphics.DrawString(word.Word, font, brush, position);
        }

        return bitmap;
    }
}
