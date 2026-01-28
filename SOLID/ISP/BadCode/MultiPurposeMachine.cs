
using System.Reflection.Metadata;

public class MultiPurposeMachine : IMachine
{
    public void print(Document doc)
    {
        Console.WriteLine("Printing the document....");
    }

    public void scan(Document doc)
    {
        Console.WriteLine("Scanning the document....");
    }

    public void copy(Document doc)
    {
        Console.WriteLine("Copying the document.....");
    }
}