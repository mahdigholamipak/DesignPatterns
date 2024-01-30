namespace Decorator;

class Program
{
    static void Main(string[] args)
    {
        var myCoffee = new SimpleCoffee();
        Console.WriteLine($"{myCoffee.GetCost():c}");
        Console.WriteLine(myCoffee.GetDescription());

        var milkCoffee = new MilkCoffee(myCoffee);
        Console.WriteLine($"{milkCoffee.GetCost():c}");
        Console.WriteLine(milkCoffee.GetDescription());

        var whipCoffee = new WhipCoffee(milkCoffee);
        Console.WriteLine($"{whipCoffee.GetCost():c}");
        Console.WriteLine(whipCoffee.GetDescription());

        var vanillaCoffee = new VanillaCoffee(whipCoffee);
        Console.WriteLine($"{vanillaCoffee.GetCost():c}");
        Console.WriteLine(vanillaCoffee.GetDescription());
    }
}


interface ICoffee
{
    int GetCost();
    string GetDescription();
}

class SimpleCoffee : ICoffee
{
    public int GetCost()
    {
        return 5;
    }

    public string GetDescription()
    {
        return "Simple Coffee";
    }
}

class MilkCoffee : ICoffee
{
    private readonly ICoffee _coffee;

    public MilkCoffee(ICoffee coffee)
    {
        _coffee = coffee ?? throw new ArgumentNullException("coffee", "coffee should not be null");
    }
    public int GetCost()
    {
        return _coffee.GetCost() + 1;
    }

    public string GetDescription()
    {
        return String.Concat(_coffee.GetDescription(), ", milk");
    }
}

class WhipCoffee : ICoffee
{
    private readonly ICoffee _coffee;

    public WhipCoffee(ICoffee coffee)
    {
        _coffee = coffee ?? throw new ArgumentNullException("coffee", "coffee should not be null");
    }
    public int GetCost()
    {
        return _coffee.GetCost() + 1;
    }

    public string GetDescription()
    {
        return String.Concat(_coffee.GetDescription(), ", whip");
    }
}

class VanillaCoffee : ICoffee
{
    private readonly ICoffee _coffee;

    public VanillaCoffee(ICoffee coffee)
    {
        _coffee = coffee ?? throw new ArgumentNullException("coffee", "coffee should not be null");
    }
    public int GetCost()
    {
        return _coffee.GetCost() + 1;
    }

    public string GetDescription()
    {
        return String.Concat(_coffee.GetDescription(), ", vanilla");
    }
}




