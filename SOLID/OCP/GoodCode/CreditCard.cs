namespace GoodCode;

public class CreditCard : IPaymentMethod
{
    public void pay(double amount)
    {
        Console.WriteLine("Making payment via Credit card : "+amount);
    }
}