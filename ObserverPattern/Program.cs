using WithObserver;

class Program
{
    static void Main()
    {
        WeatherStation weatherStation = new WeatherStation();

        DisplayDevice displayDevice = new DisplayDevice();
        Mobile mobile = new Mobile();
        Laptop laptop = new Laptop();

        weatherStation.attach(displayDevice);
        weatherStation.attach(mobile);
        weatherStation.attach(laptop);

        weatherStation.setTemperature(32.20);

        Console.WriteLine("\n");

        weatherStation.dettach(displayDevice);
        weatherStation.setTemperature(23.23);
        
        Console.WriteLine("\n");
    }
}