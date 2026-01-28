namespace GoodCode;

public class Invoice
{
    private double amount;

    public Invoice(double _amount)
    {
        amount = _amount;
    }

    public void GenerateInvoice()
    {
        Console.WriteLine("Generating Invoice.....");
    }

}