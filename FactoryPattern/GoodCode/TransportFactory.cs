public class TransportFactory
{
    public static ITransport GetTransport(string type)
    {
        // Adding related new subclasses becomes easy by managing it in one place

        switch(type.ToLower())
        {
            case "bike": return new Bike();
            case "car": return new Car();
            case "bus": return new Bus();
            default: throw new Exception("Unsupported Transport Type.");
        }
    }
}