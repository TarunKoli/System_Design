public class DisplayDevice2
{
    public void showTemp(double temp)
    {
        Console.WriteLine("Current Temp: "+temp);
    }
}

public class WeatherStation2
{
    private double temperature;
    DisplayDevice2 displayDevice;

    public WeatherStation2(DisplayDevice2 dd)
    {
        displayDevice = dd;        
    }

    public void SetTemperature(double temp)
    {
        temperature = temp;
        Notify();
    }    

    public void Notify()
    {
        displayDevice.showTemp(temperature);
    }
}