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

    public static void WriteToFile<T>(string path, List<T> data)
    {
        var json = JsonSerializer.Serialize(data, _writeOptions);

        File.AppendAllText(path, json);
    }
}