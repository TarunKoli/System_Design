namespace GoodCode;


public class PaymentProcessor
{
    public void processPayment(IPaymentMethod paymentMethod)
    {
        paymentMethod.pay(100.00);
    }
}
