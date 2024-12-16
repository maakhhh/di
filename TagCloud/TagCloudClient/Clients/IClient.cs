namespace TagCloudClient.Clients;

public interface IClient
{
    public SettingsManager GetSettings();
    public void WritePath(string path);
}
