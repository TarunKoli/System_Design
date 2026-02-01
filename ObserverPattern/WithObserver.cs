namespace WithObserver;

public interface IObserver
{
    void update(double temp);
}

public interface ISubject
{
    void attach(IObserver observer);
    void dettach(IObserver observer);
    void notifyObserver();
}

public class WeatherStation : ISubject
{
    private double temperature;
    private List<IObserver> observers;

    public WeatherStation()
    {
        observers = new List<IObserver>();
    }

    public void setTemperature(double temp)
    {
        temperature = temp;
        notifyObserver();
    }

    public void attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void dettach(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void notifyObserver()
    {
        observers.ForEach(observer =>
        {
            observer.update(temperature);
        });
    }

}

public class DisplayDevice : IObserver
{
    public void update(double temp)
    {
        Console.WriteLine("Display Device temperature: "+temp);
    }    
}

public class Mobile : IObserver
{
    public void update(double temp)
    {
        Console.WriteLine("Mobile temperature: "+temp);
    }    
}

public class Laptop : IObserver
{
    public void update(double temp)
    {
        Console.WriteLine("Laptop temperature: "+temp);
    }    
}