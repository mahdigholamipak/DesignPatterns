namespace AbstractFactory;

class Program
{
    static void Main(string[] args)
    {
        var windowsGUIFactory = new WindowsGUIFactory();
        var windowsGUI = windowsGUIFactory.CreateButton();
        windowsGUI.Render();

        var webGUIFactory = new WebGUIFactory();
        var webGUI = webGUIFactory.CreateButton();
        webGUI.Render();
    }
}

public interface IButton
{
    void Render();
}

public class WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering Windows button...");
    }
}

public class WebButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering Web button...");
    }
}

public interface IGUIFactory
{
    IButton CreateButton();
}

public class WindowsGUIFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new WindowsButton();
    }
}

public class WebGUIFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new WebButton();
    }
}
