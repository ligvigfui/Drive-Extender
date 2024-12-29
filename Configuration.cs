using System.Text.Json;

namespace Drive_Extender;

public class Configuration
{
    public static Configuration configuration;
    public static string ConfigPath = "configuration.json";

    public string DriveFolderPath { get; set; }
    public string ConfigJsonPath { get; set; }
    public List<PathMapping> Mappings { get; set; } = [];


    public static void Save() =>
        File.WriteAllText(ConfigPath, JsonSerializer.Serialize(configuration));

    public static void Load(Action<string> errorShowMethod)
    {
        if (!File.Exists(ConfigPath))
        {
            configuration = new Configuration();
            try
            {
                Save();
            }
            catch (Exception e)
            {
                errorShowMethod($"Error creating configuration file:\n{e.Message}");
            }
            return;
        }

        try
        {
            var json = File.ReadAllText(ConfigPath);
            var configuration = JsonSerializer.Deserialize<Configuration>(json);
            if (configuration is null)
            {
                errorShowMethod("Configuration file is empty. We created a new empty configuration file for you.");
                configuration = new Configuration();
            }
            else
            {
                Configuration.configuration = configuration;
            }
        }
        catch (Exception e)
        {
            errorShowMethod($"Error loading configuration file:\n{e.Message}\n\nWe created a new configuration file for you.");
            configuration = new Configuration();
        }
    }
}
