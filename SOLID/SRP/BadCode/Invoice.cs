namespace BadCode;

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

    public void EmailInvoice()
    {
        Console.WriteLine("Sending Invoice on email.....");
    }

    public void SaveInvoiceToDatabase()
    {
        Console.WriteLine("Saving Invoice to database.....");
    }
}
