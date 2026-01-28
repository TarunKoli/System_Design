using System.Reflection.Metadata;

public class SimplePrinter: IPrint
{
    public void print(Document doc)
    {
        Console.WriteLine("Printing the document.....");
    }    
}