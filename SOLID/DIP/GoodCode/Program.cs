class Program
{
    static void Main()
    {
        NotificationService emailService = new NotificationService(new EmailService());
        NotificationService smsService = new NotificationService(new SmsService());

        emailService.notify("Your order has been shipped");
        smsService.notify("OTP: 1234");
    }
}