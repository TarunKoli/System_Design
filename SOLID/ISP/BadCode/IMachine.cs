using System.Reflection.Metadata;

public interface IMachine
{
    void print(Document doc);
    void scan(Document doc);
    void copy(Document doc);
}