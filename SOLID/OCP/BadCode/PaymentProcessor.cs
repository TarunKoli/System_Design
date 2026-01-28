namespace BadCode.PaymentProcessor;

public class PaymentProcessor
{
    public void processPayment(string paymentMethod, double amount)
    {
        if(paymentMethod.Equals("CreditCard"))
        {
            Console.WriteLine("Making Payment through Credit Card....");
        }
        else if(paymentMethod.Equals("DebitCard"))
        {
            Console.WriteLine("Making Payment through Debit Card....");
        }
        else if(paymentMethod.Equals("Paypal"))
        {
            Console.WriteLine("Making Payment through Paypal....");
        }
        else
        {
            Console.WriteLine("Payment Method Not Configured");
        }
    }
}
