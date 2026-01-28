namespace GoodCode;

class Program
{
    static void Main()
    {
        IPaymentMethod creditCard = new CreditCard();
        IPaymentMethod debitCard = new DebitCard();
        IPaymentMethod upi = new UPI();

        PaymentProcessor pm = new PaymentProcessor();
        pm.processPayment(creditCard);
        pm.processPayment(debitCard);
        pm.processPayment(upi);

    }
}
