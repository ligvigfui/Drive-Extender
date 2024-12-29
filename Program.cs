namespace Drive_Extender;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Configuration.Load(LoggerService.LogWarning);
        var notifyIcon = new NotifyIcon()
        {
            Icon = new Icon("Assets/icon.ico"), // Ensure you have an icon file named "icon.ico"
            Visible = true
        };
        notifyIcon.Click += (sender, args) =>
        {
            using var settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        };

        var backgroundTaskService = new BackgroundTaskService(); // Set your desired interval
        backgroundTaskService.Start();

        Application.Run();

        // Ensure the background task service is stopped when the application exits
        backgroundTaskService.Stop();
    }
}