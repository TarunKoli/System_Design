public class AppSettings
{
    private static AppSettings? instance;
    private string dbConn;
    private string apiKey;

    private AppSettings()
    {
        dbConn = "http://localhost:3000/dbconn";
        apiKey = "test";
    }

    public static AppSettings getInstance()
    {
        if(instance==null)
        {
            instance = new AppSettings();
        }
        return instance;
    }

    public string getDatabaseUrl()
    {
        return dbConn;
    }

    public string getApiKey()
    {
        return apiKey;
    }
}