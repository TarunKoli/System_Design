namespace GoodCode;

public class DebitCard : IPaymentMethod
{
    public void pay(double amount)
    {
        Console.WriteLine("Making payment via Debit card : "+ amount);
    }
}