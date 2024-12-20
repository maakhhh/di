using Autofac;
using TagCloud;
using TagCloud.BitmapGenerators;
using TagCloud.CloudImageSavers;
using TagCloud.CloudLayouter;
using TagCloud.CloudLayouter.PositionGenerator;
using TagCloud.SettingsProviders;
using TagCloud.TextFilters;
using TagCloud.TextReader;
using TagCloudClients.ConsoleClients;

namespace TagCloudClients;

internal static class ContainerBuilderExtensions
{
    public static ContainerBuilder WithServices(this ContainerBuilder builder)
    {
        builder.RegisterType<BitmapGenerator>().As<IBitmapGenerator>();
        builder.RegisterType<CloudImageSaver>().As<ICloudImageSaver>();
        builder.RegisterType<CircularCloudLayouter>().As<ICloudLayouter>();
        builder.RegisterType<BoringTextFilter>().As<ITextFilter>();
        builder.RegisterType<LowercaseTextFilter>().As<ITextFilter>();
        builder.RegisterType<TxtTextReader>().As<ITextReader>();
        builder.RegisterType<TagCloudImageGenerator>().AsSelf();

        return builder;
    }

    public static ContainerBuilder WithSettings(this ContainerBuilder builder)
    {
        builder.RegisterType<BitmapSettingsProvider>()
            .As<ISettingsProvider<BitmapGeneratorSettings>>().SingleInstance();
        builder.RegisterType<SaveSettingsProvider>()
            .As<ISettingsProvider<SaveSettings>>().SingleInstance();
        builder.RegisterType<SpiralGeneratorSettingsProvider>()
            .As<ISettingsProvider<SpiralGeneratorSettings>>().SingleInstance();
        builder.RegisterType<TextReaderSettingsProvider>()
            .As<ISettingsProvider<TextReaderSettings>>().SingleInstance();

        return builder;
    }

    public static ContainerBuilder WithConsoleClient(this ContainerBuilder builder)
    {
        builder.RegisterType<ConsoleClient>().As<IClient>();
        return builder;
    }
}
