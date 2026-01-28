public class WriteableFile : ReadableFile, IWriteable
{
    public void Write()
    {
        Console.WriteLine("Writing File....");
    }    
}