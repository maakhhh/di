namespace TagCloud;

public interface IClient
{
    public SettingsManager GetSettings();
    public void WritePath(string path);
}
