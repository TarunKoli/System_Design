public class NotificationService
{
    private EmailService emailService;
    private SmsService smsService;

    public NotificationService()
    {
        emailService = new EmailService();
        smsService = new SmsService();
    }

    public void NotifyByEmail(string msg)
    {
        emailService.sendEmail(msg);
    }

    public void NotifyBySms(string msg)
    {
        smsService.sendSms(msg);
    }
}