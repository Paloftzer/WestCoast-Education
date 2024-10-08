using System.Text.Encodings.Web;
using System.Text.Json;

namespace WestCoast_Education.models;

public class FileManager
{
    // Write options for the json Serializer
    private static readonly JsonSerializerOptions _writeOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    };

    // Read options for the json Deserializer, technically I could've had one option instead that combined read and write but this feels better to me
    private static readonly JsonSerializerOptions _readOptions = new()
    {
        PropertyNameCaseInsensitive = true
    };

    // Had to move the dynamic path to a separate method because otherwise it stopped working and i genuinely don't know why but it works now so
    private static string GetFilePath<T>()
    {
        // Dynamically generates path depending on what class is calling the method so that I don't have to declare a path variable in every individual class
        string fileName = $"{typeof(T).Name}.json";
        return string.Concat(Environment.CurrentDirectory, "/data/", fileName);
    }

    // Method that writes the information to a .json file with the name generated in GetFilePath
    public static void WriteToFile<T>(List<T> data)
    {
        var json = JsonSerializer.Serialize(data, _writeOptions);
        // Gets the class dependent file path from GetFilePath
        string path = GetFilePath<T>();

        File.WriteAllText(path, json);
    }

    // Method that reads the information stored in the .json file
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
        // Deserializes the information from the .json file or returns and empty list incase something fails
        return JsonSerializer.Deserialize<List<T>>(json, _readOptions) ?? [];
    }
}