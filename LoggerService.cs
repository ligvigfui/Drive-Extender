namespace Drive_Extender;

public static class LoggerService
{
    public static string LogFilePath { get; set; } = $"app_{DateTime.Now:yyyyMMdd}.log";
    public static void Log(string message, LogLevel logLevel) =>
        File.AppendAllText(LogFilePath, $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{logLevel}] {message}\n");

    public static void LogInfo(string message) => Log(message, LogLevel.Info);
    public static void LogWarning(string message) => Log(message, LogLevel.Warning);
    public static void LogError(string message) => Log(message, LogLevel.Error);
}
