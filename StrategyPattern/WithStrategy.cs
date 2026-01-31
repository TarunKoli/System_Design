public interface IPaymentStrategy
{
    void pay();    
}

public class CreditCard : IPaymentStrategy
{
    public void pay()
    {
        Console.WriteLine("Making Payment via credit card....");
    }    
}

public class DebitCard : IPaymentStrategy
{
    public void pay()
    {
        Console.WriteLine("Making Payment via debit card....");
    }    
}

public class UPI : IPaymentStrategy
{
    public void pay()
    {
        Console.WriteLine("Making Payment via UPI....");
    }    
}

public class PaymentService
{
    IPaymentStrategy strategy;

    public PaymentService(IPaymentStrategy _strategy)
    {
        strategy = _strategy;
    }

    public void ProcessPayment()
    {
        strategy.pay();
    }
}


class WithStrategy
{
    static void Main()
    {
        PaymentService creditCard = new PaymentService(new CreditCard());
        creditCard.ProcessPayment();
    }
}