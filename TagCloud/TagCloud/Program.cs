using CommandLine;
using Microsoft.Extensions.DependencyInjection;
using TagCloud.BitmapGenerators;
using TagCloud.CloudImageSavers;
using TagCloud.CloudLayouter;
using TagCloud.TextFilters;
using TagCloud.TextReader;

namespace TagCloud;

public static class Program
{
    public static void Main(string[] args)
    {
        var client = new ConsoleClient(args);
        var settings = client.GetSettings();

        var services = new ServiceCollection();
        RegisterServices(services);
        RegisterSettings(services, settings);

        var provider = services.BuildServiceProvider();
        var generator = provider.GetService<TagCloudImageGenerator>();
        generator.GenerateCloud();
        client.WritePath(generator.TagCloudPath);
    }

    private static void RegisterServices(IServiceCollection services)
    {
        services.AddSingleton<IBitmapGenerator, BitmapGenerator>();
        services.AddSingleton<ICloudImageSaver, CloudImageSaver>();
        services.AddSingleton<ICloudLayouter, CircularCloudLayouter>();
        services.AddSingleton<IPositionGenerator, SpiralPositionGenerator>();
        services.AddSingleton<ITextFilter, BoringTextFilter>();
        services.AddSingleton<ITextFilter, LowercaseTextFilter>();
        services.AddSingleton<ITextReader, TxtTextReader>();
        services.AddSingleton<TagCloudImageGenerator>();
    }

    private static void RegisterSettings(IServiceCollection services, SettingsManager settings)
    {
        services.AddSingleton(settings.BitmapGeneratorSettings);
        services.AddSingleton(settings.SaveSettings);
        services.AddSingleton(settings.SpiralGeneratorSettings);
        services.AddSingleton(settings.TextReaderSettings);
    }
}
