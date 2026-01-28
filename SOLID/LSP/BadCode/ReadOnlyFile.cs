

public class ReadOnlyFile : File
{
    public override void write()
    {
        throw new Exception("Can't write to read only file");
    }
}