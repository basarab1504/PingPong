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

    public bool TryLoad<T>(string path, out T data)
    {
        string fullPath = Application.persistentDataPath + "\\" + path;

        if (!File.Exists(fullPath))
        {
            data = default(T);
            return false;
        }

        var json = File.ReadAllText(fullPath);
        data = JsonUtility.FromJson<T>(json);
        
        return true;
    }
}
