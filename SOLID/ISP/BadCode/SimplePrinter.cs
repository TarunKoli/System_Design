using System.Reflection.Metadata;

public class SimplePrinter
{
    public void print(Document doc)
    {
        Console.WriteLine("Printing the document.....");
    }

    public void scan(Document doc)
    {
        throw new Exception("Unsupported Command scan....");
    }

    public void copy(Document doc)
    {
        throw new Exception("Unsupported Command copy....");
    }
}