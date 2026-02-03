class TransportService
{
    static void Main()
    {
        ITransport bike = new Bike();
        ITransport car = new Car();
        ITransport bus = new Bus();

        bike.deliver();

        // managing many objects, making this class tightCoupled with object class
    }
}