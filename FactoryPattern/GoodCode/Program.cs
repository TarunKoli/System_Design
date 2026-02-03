class TransportService
{
    static void Main()
    {
        ITransport bike = TransportFactory.GetTransport("bike");

        bike.deliver();
    }
}