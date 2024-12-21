using Autofac;
using TagCloud;
using TagCloud.BitmapGenerators;
using TagCloud.CloudImageSavers;
using TagCloud.CloudLayouter;
using TagCloud.CloudLayouter.PositionGenerator;
using TagCloud.SettingsProviders;
using TagCloud.TextFilters;
using TagCloud.TextReader;
using TagCloud.TextSplitters;
using TagCloudClients.ConsoleClients;

namespace TagCloudClients;

internal static class ContainerBuilderExtensions
{
    public static ContainerBuilder WithServices(this ContainerBuilder builder)
    {
        builder.RegisterType<BitmapGenerator>().As<IBitmapGenerator>();
        builder.RegisterType<CloudImageSaver>().As<ICloudImageSaver>();
        builder.RegisterType<CircularCloudLayouter>().As<ICloudLayouter>();
        builder.RegisterType<SpiralPositionGenerator>().As<IPositionGenerator>();
        builder.RegisterType<BoringTextFilter>().As<ITextFilter>();
        builder.RegisterType<LowercaseTextFilter>().As<ITextFilter>();
        builder.RegisterType<TxtTextReader>().As<ITextReader>();
        builder.RegisterType<EnterTextSplitter>().As<ITextSplitter>();
        builder.RegisterType<TagCloudImageGenerator>().AsSelf();

        return builder;
    }

    public static ContainerBuilder WithSettings(this ContainerBuilder builder)
    {
        builder.RegisterType<SettingsProvider<BitmapGeneratorSettings>>()
            .As<ISettingsProvider<BitmapGeneratorSettings>, ISettingsHolder<BitmapGeneratorSettings>>()
            .SingleInstance();
        builder.RegisterType<SettingsProvider<SaveSettings>>()
            .As<ISettingsProvider<SaveSettings>, ISettingsHolder<SaveSettings>>()
            .SingleInstance();
        builder.RegisterType<SettingsProvider<SpiralGeneratorSettings>>()
            .As<ISettingsProvider<SpiralGeneratorSettings>, ISettingsHolder<SpiralGeneratorSettings>>()
            .SingleInstance();
        builder.RegisterType<SettingsProvider<TextReaderSettings>>()
            .As<ISettingsProvider<TextReaderSettings>, ISettingsHolder<TextReaderSettings>>()
            .SingleInstance();

        return builder;
    }

    public static ContainerBuilder WithConsoleClient(this ContainerBuilder builder, string[] args)
    {
        builder.RegisterInstance(args);
        builder.RegisterType<ConsoleClient>().As<IClient>();
        return builder;
    }
}
