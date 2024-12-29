namespace Drive_Extender;

public abstract class FileSystemElement
{
    public string Name { get; set; }
    public DateTime LastModified { get; set; }
    public string? WantedByDeviced { get; set; } = null;
}
