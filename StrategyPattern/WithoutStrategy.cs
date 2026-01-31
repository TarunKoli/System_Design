

public class PaymentService
{
    public void ProcessPayment(string paymentMethod)
    {
        if(paymentMethod=="Credit Card")
        {
            Console.WriteLine("Making payment via credit card....");
        }
        else if(paymentMethod=="Debit Card")
        {
            Console.WriteLine("Making payment via debit card....");
            
        }
        else if(paymentMethod=="Paypal")
        {
            Console.WriteLine("Making payment via paypal....");
        }
        else
        {
            Console.WriteLine("payment method not configured");
        }
    }
}

class WithoutStrategy
{
    static void Main()
    {
        PaymentService paymentService = new PaymentService();

        paymentService.ProcessPayment("Credit Card");
    }
}