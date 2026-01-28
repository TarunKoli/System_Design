public class NotificationService
{
    private INotificationChannel notificationChannel;

    public NotificationService(INotificationChannel _notificationChannel)
    {
        notificationChannel = _notificationChannel;
    }

    public void notify(string msg)
    {
        notificationChannel.send(msg);
    }
}