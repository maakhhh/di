using CommandLine;

namespace TagCloud;

public class Options
{
    [Value(0, Required = true, HelpText = "Path of file with words")]
    public string InputPath { get; set; }
}
