using System.IO;
using UnityEngine;

public class JsonDataProvider : IFileDataProvider
{
    public void Save<T>(string path, T data)
    {
        string fullPath = Application.persistentDataPath + "\\" + path;

        var json = JsonUtility.ToJson(data);
        File.WriteAllText(fullPath, json);
    }

    public T Load<T>(string path)
    {
        string fullPath = Application.persistentDataPath + "\\" + path;

        if (!File.Exists(fullPath))
            return default(T);

        var json = File.ReadAllText(fullPath);
        return JsonUtility.FromJson<T>(json);
    }
}
