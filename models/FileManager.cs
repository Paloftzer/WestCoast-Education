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

    public static void WriteToFile<T>(List<T> data)
    {
        // Dynamically generates the filename specific to the class that is using the function instead of having to declare a separate path in each class
        string fileName = $"{typeof(T).Name}.json";
        string path = string.Concat(Environment.CurrentDirectory, "/data/", fileName);

        var json = JsonSerializer.Serialize(data, _writeOptions);

        File.WriteAllText(path, json);
    }
}