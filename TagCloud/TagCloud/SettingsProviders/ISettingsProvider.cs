namespace TagCloud.SettingsProviders;

public interface ISettingsProvider<T>
{
    public T GetSettings();
    public void SetSettings(T settings);
}
