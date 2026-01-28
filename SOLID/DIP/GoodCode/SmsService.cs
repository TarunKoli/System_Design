public class SmsService : INotificationChannel
{
    public void send(string msg)
    {
        Console.WriteLine("Sending sms: "+ msg);
    }    
}