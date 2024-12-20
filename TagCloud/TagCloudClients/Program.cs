using Autofac;

namespace TagCloudClients;

public static class Program
{
    public static void Main()
    {
        using var container = new ContainerBuilder()
            .WithServices()
            .WithSettings()
            .WithConsoleClient()
            .Build();

        container.Resolve<IClient>().Run();
    }
}