using System.Text.Encodings.Web;
using System.Text.Json;

namespace WestCoast_Education.models;

public class FileManager
{
    private static readonly JsonSerializerOptions _writeOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    };

    private static readonly JsonSerializerOptions _readOptions = new()
    {
        PropertyNameCaseInsensitive = true
    };

    // Had to move the dynamic path to a separate method because otherwise it stopped working
    private static string GetFilePath<T>()
    {
        string fileName = $"{typeof(T).Name}.json";
        return string.Concat(Environment.CurrentDirectory, "/data/", fileName);
    }

    public static void WriteToFile<T>(List<T> data)
    {
        var json = JsonSerializer.Serialize(data, _writeOptions);
        string path = GetFilePath<T>();

        File.WriteAllText(path, json);
    }

    public static List<T> ReadFromFile<T>()
    {   
        string path = GetFilePath<T>();

        // Check to see if the file exists
        if (!File.Exists(path))
        {
            // If the file doesn't exist return an empty list
            return [];
        }

        var json = File.ReadAllText(path);
        return JsonSerializer.Deserialize<List<T>>(json, _readOptions) ?? [];
    }
}