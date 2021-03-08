public interface ISerializeable<T>
{
    void Load(T data);
    T Save();
}
