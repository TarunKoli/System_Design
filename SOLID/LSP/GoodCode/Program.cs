class Program
{

    public static void ReadAnyFile(ReadableFile file)
    {
        file.Read();
    }

    static void Main()
    {
        ReadableFile readableFile = new ReadableFile();
        readableFile.Read();

        WriteableFile writeableFile = new WriteableFile();
        writeableFile.Read();
        writeableFile.Write();

        ReadAnyFile(readableFile);
        ReadAnyFile(writeableFile);
    }
}