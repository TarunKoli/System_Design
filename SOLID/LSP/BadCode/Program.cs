

class Program
{
    static void Main()
    {
        File file = new ReadOnlyFile();

        file.read();
        file.write();
    }
}