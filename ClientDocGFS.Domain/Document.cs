namespace ClientDocGFS.Domain;

/// <summary>
/// abstract class that represent a document
/// </summary>
public abstract class Document
{
    public string Path { get; set; }

    protected Document(string path)
    {
        Path = path;
    }
}