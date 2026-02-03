class Program
{
    static void Main()
    {
        AppSettings appSetting1 = AppSettings.getInstance();
        AppSettings appSetting2 = AppSettings.getInstance();

        Console.WriteLine(appSetting1==appSetting2);
    }
}