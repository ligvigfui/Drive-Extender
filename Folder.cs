namespace Drive_Extender;

public class Folder : FileSystemElement
{
    public List<FileSystemElement> Children { get; set; } = [];
}
