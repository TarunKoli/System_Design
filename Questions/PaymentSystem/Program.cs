public interface IPaymentMethod
{
    void Pay(double amount);
}

public interface IService
{
    void Notification(string msg);
}

public interface INotificationService
{
    void Subscribe(IService service);
    void Unsubscribe(IService service);
    void Notify(string msg);
}

public class SMS : IService
{
    public void Notification(string msg)
    {
        Console.WriteLine($"SMS Notification: {msg}");
    }
}

public class Email : IService
{
    public void Notification(string msg)
    {
        Console.WriteLine($"Email Notification: {msg}");
    }
}

public class NotificationService : INotificationService
{
    private HashSet<IService> services;

    public NotificationService()
    {
        services = new HashSet<IService>();
    }

    public void Subscribe(IService service)
    {
        services.Add(service);
    }

    public void Unsubscribe(IService service)
    {
        services.Remove(service);
    }

    public void Notify(string msg)
    {
        foreach(IService service in services)
        {
            service.Notification(msg);
        }
    }
}

public class CreditCard : IPaymentMethod
{
    public void Pay(double amount)
    {
        Console.WriteLine("Making payment via Credit Card....");
    }
}

public class DebitCard : IPaymentMethod
{
    public void Pay(double amount)
    {
        Console.WriteLine("Making payment via Debit Card....");
    }
}

public class UPI : IPaymentMethod
{
    public void Pay(double amount)
    {
        Console.WriteLine("Making payment via UPI....");
    }
}

public class Wallet : IPaymentMethod
{
    public void Pay(double amount)
    {
        Console.WriteLine("Making payment via Wallet....");
    }
}

public class PaymentService
{
    private IPaymentMethod paymentMethod;
    private INotificationService notificationService;

    public PaymentService(INotificationService notificationService)
    {
        paymentMethod = PaymentFactory.getPaymentMethod("CreditCard");
        this.notificationService = notificationService;
    }

    public void SetPaymentMethod(IPaymentMethod method)
    {
        paymentMethod = method;
    }

    public void ProcessPayment(double amount)
    {
        paymentMethod.Pay(amount);       
        notificationService.Notify($"Payment Collected for rupee: {amount}");
    }
}

public class PaymentFactory
{
    public static IPaymentMethod getPaymentMethod(string method)
    {
        switch(method.ToLower())
        {
            case "creditcard" : return new CreditCard();
            case "debitcard" : return new DebitCard();
            case "upi" : return new UPI();
            case "wallet" : return new Wallet();
            default : return new CreditCard();
        }
    }
}


public class Application
{
    static void Main()
    {
        NotificationService notificationService = new NotificationService();
        notificationService.Subscribe(new Email());
        notificationService.Subscribe(new SMS());
        
        PaymentService paymentService = new PaymentService(notificationService);
        IPaymentMethod paymentMethod = PaymentFactory.getPaymentMethod("UPI");

        paymentService.SetPaymentMethod(paymentMethod);
        paymentService.ProcessPayment(456.87);
    }
}