public interface IButton
{
    void render();
}

public interface IScrollbar
{
    void scroll();
}

public interface IUIFactory
{
    IButton CreateButton();
    IScrollbar CreateScrollbar();
}

public class WindowsButton : IButton
{
    public void render()
    {
        Console.WriteLine("Rendering windows button...");
    }
}

public class WindowsScrollbar : IScrollbar
{
    public void scroll()
    {
        Console.WriteLine("Rendering windows Scrollbar...");
    }
}

public class MacOsButton : IButton
{
    public void render()
    {
        Console.WriteLine("Rendering Macos button...");
    }
}

public class MacOsScrollbar : IScrollbar
{
    public void scroll()
    {
        Console.WriteLine("Rendering Macos Scrollbar...");
    }
}

public class WindowsFactory : IUIFactory
{
    public IButton CreateButton()
    {
        return new WindowsButton();
    }

    public IScrollbar CreateScrollbar()
    {
        return new WindowsScrollbar();
    }
}

public class MacOsFactory : IUIFactory
{
    public IButton CreateButton()
    {
        return new MacOsButton();
    }

    public IScrollbar CreateScrollbar()
    {
        return new MacOsScrollbar();
    }
}

class Application
{
    public IButton button;
    public IScrollbar scrollbar;

    public Application(IUIFactory uIFactory)
    {
        this.button = uIFactory.CreateButton();
        this.scrollbar = uIFactory.CreateScrollbar();
    }

    static void Main()
    {
        // Sepration of environments

        Application application1 = new Application(new WindowsFactory());

        application1.button.render();
        application1.scrollbar.scroll();

        Application application2 = new Application(new MacOsFactory());

        application2.button.render();
        application2.scrollbar.scroll();
    }
}