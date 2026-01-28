public class EmailService : INotificationChannel
{
    public void send(string msg)
    {
        Console.WriteLine("Sending email: "+ msg);
    }
}