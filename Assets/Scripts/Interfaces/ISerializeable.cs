public interface ISerializeable
{
    void Load<T>(T data);
    T Save<T>();
}
