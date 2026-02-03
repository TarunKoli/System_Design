public class WindowsButton
{
    public void render()
    {
        Console.WriteLine("Rendering windows button....");
    }
}

public class WindowsScrollBar
{
    public void scroll()
    {
        Console.WriteLine("Rendering windows scrollbar....");
    }
}

public class MacOsButton
{
    public void render()
    {
        Console.WriteLine("Rendering MacOs button....");
    }
}

public class MacOsScrollbar
{
    public void scroll()
    {
        Console.WriteLine("Rendering MacOsScrollbar....");
    }
}

class Application
{
    static void Main()
    {
        WindowsButton windowsButton = new WindowsButton();
        MacOsScrollbar macOsScrollbar = new MacOsScrollbar();

        // mixing of both UI's
        windowsButton.render();
        macOsScrollbar.render();
    }
}