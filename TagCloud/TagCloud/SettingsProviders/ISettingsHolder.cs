namespace TagCloud.SettingsProviders;

public interface ISettingsHolder<in T> where T : new()
{
    public void SetSettings(T settings);
}
