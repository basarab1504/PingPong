public interface IFileDataProvider
{
    bool TryLoad<T>(string path, out T data);
    void Save<T>(string path, T data);
}
