class Program
{
    static void Main()
    {
        AppSettings appSetting1 = new AppSettings();
        AppSettings appSetting2 = new AppSettings();

        Console.WriteLine(appSetting1==appSetting2);
    }
}