namespace GoodCode;

public class UPI : IPaymentMethod
{
    public void pay(double amount)
    {
        Console.WriteLine("Making Payment via UPI : "+amount);
    }
}