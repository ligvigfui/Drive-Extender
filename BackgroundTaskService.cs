using Timer = System.Threading.Timer;

namespace Drive_Extender;

public class BackgroundTaskService()
{
    private Timer _timer;

    public void Start() =>
        _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromMinutes(1));

    public void Stop() =>
        _timer?.Change(Timeout.Infinite, 0);

    void TimerChange(TimeSpan timeSpan) =>
        _timer.Change(TimeSpan.Zero, timeSpan);

    private void DoWork(object state)
    {
        // Your background task logic here
        LoggerService.LogInfo("Background task executed.");
    }

    void MapFolder(Folder folder)
    {
    }



    public Folder CreateFileTree(string folderPath)
    {
        var folder = new Folder
        {
            Name = Path.GetFileName(folderPath),
            LastModified = Directory.GetLastWriteTime(folderPath),
            Children = CreateFileTreeRecursive(folderPath)
        };
        return folder;
    }

    List<FileSystemElement> CreateFileTreeRecursive(string folderPath)
    {
        var elements = new List<FileSystemElement>();
        foreach (var directory in Directory.GetDirectories(folderPath))
        {
            var folder = new Folder
            {
                Name = Path.GetFileName(directory),
                LastModified = Directory.GetLastWriteTime(directory),
                Children = CreateFileTreeRecursive(directory)
            };
            elements.Add(folder);
        }

        foreach (var file in Directory.GetFiles(folderPath))
        {
            var myFile = new MyFile
            {
                Name = Path.GetFileName(file),
                LastModified = File.GetLastWriteTime(file),
                Size = new FileInfo(file).Length.ToString()
            };
            elements.Add(myFile);
        }

        return elements;
    }
}
