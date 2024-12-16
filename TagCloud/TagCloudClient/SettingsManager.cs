using TagCloud.BitmapGenerators;
using TagCloud.CloudImageSavers;
using TagCloud.CloudLayouter.PositionGenerator;
using TagCloud.TextReader;

namespace TagCloudClient;

public record class SettingsManager(
    BitmapGeneratorSettings BitmapGeneratorSettings,
    SaveSettings SaveSettings,
    SpiralGeneratorSettings SpiralGeneratorSettings,
    TextReaderSettings TextReaderSettings);
