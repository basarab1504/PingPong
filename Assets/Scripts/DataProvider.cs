using System.IO;
using System.Xml.Serialization;
using UnityEngine;

public class DataProvider
{
    public void Save<T>(string path, T data)
    {
        string fullPath = Application.persistentDataPath + "\\" + path;

        using (var stream = new FileStream(fullPath, FileMode.OpenOrCreate))
        {
            var serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(stream, data);
        }
    }

    public T Load<T>(string path)
    {
        string fullPath = Application.persistentDataPath + "\\" + path;

        if (!File.Exists(fullPath))
            return default(T);

        using (var stream = new FileStream(fullPath, FileMode.Open))
        {
            var serializer = new XmlSerializer(typeof(T));
            return (T)serializer.Deserialize(stream);
        }
    }
}
