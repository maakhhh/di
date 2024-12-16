using CommandLine;

namespace TagCloud;

public class ConsoleClient : IClient
{
    private readonly string[] args;

    public ConsoleClient(string[] args)
    {
        this.args = args;
    }

    public SettingsManager GetSettings()
    {
        Parser.Default.ParseArguments<Options>(args)
            .WithParsed(settings =>
            {

            });
        return new SettingsManager(null, null, null, null);
    }

    public void WritePath(string path)
    {
        throw new NotImplementedException();
    }
}
