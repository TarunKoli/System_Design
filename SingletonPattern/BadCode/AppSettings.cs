
public class AppSettings
{
    private string dbConn;
    private string apiKey;

    public AppSettings()
    {
        dbConn = "http://localhost:3000/dbconn";
        apiKey = "test";
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