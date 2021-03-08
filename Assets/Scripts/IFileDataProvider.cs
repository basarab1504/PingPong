public interface IFileDataProvider
{
    T Load<T>(string path);
    void Save<T>(string path, T data);
}
