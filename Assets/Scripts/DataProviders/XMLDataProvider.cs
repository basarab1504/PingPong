using System.IO;
using System.Xml.Serialization;
using UnityEngine;

public class XMLDataProvider : IFileDataProvider
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

    public bool TryLoad<T>(string path, out T data)
    {
        string fullPath = Application.persistentDataPath + "\\" + path;

        if (!File.Exists(fullPath))
        {
            data = default(T);
            return false;
        }

        using (var stream = new FileStream(fullPath, FileMode.Open))
        {
            var serializer = new XmlSerializer(typeof(T));
            data = (T)serializer.Deserialize(stream);
            return true;
        }
    }
}
