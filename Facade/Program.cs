namespace Facade;

class Program
{
    static void Main(string[] args)
    {
        var computer = new ComputerFacade(new Computer());
        computer.TurnOn();
        Console.WriteLine();
        computer.TurnOff();
        Console.ReadLine();
    }
}


class Computer
{
    public void GetElectricShock()
    {
        Console.Write("Ouch!");
    }

    public void MakeSound()
    {
        Console.Write("Beep beep!");
    }

    public void ShowLoadingScreen()
    {
        Console.Write("Loading..");
    }

    public void Bam()
    {
        Console.Write("Ready to be used!");
    }

    public void CloseEverything()
    {
        Console.Write("Bup bup bup buzzzz!");
    }

    public void CleanupBeforeShutdown()
    {
        Console.Write("Zzzzz");
    }

    public void TurnOffPower()
    {
        Console.Write("Haaah!");
    }
}


class ComputerFacade
{
    private readonly Computer _computer;

    public ComputerFacade(Computer computer)
    {
        this._computer = computer ?? throw new ArgumentNullException("computer", "computer cannot be null");
    }

    public void TurnOn()
    {
        _computer.GetElectricShock();
        _computer.MakeSound();
        _computer.ShowLoadingScreen();
        _computer.Bam();
    }

    public void TurnOff()
    {
        _computer.CloseEverything();
        _computer.TurnOffPower();
        _computer.CleanupBeforeShutdown();
    }
}



