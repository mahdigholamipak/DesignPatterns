namespace Builder;

class Program
{
    static void Main(string[] args)
    {
        var coffeBuilder = new CoffeBuilder("French").SetPrice(1.99f).AddSugar(true);
        var coffee = coffeBuilder.Build();
        coffee.GetDescription();
    }
}

public class Coffee
{
    private string _type;
    private float _price;
    private bool _sugar;
    public Coffee(CoffeBuilder coffeBuilder)
    {
        _type = coffeBuilder.type;
        _price = coffeBuilder.price;
        _sugar = coffeBuilder.sugar;
    }
    public void GetDescription()
    {
        System.Console.WriteLine($"This is a {_type} coffee.");
    }
}

public class CoffeBuilder
{
    public string type;
    public float price;
    public bool sugar;
    public CoffeBuilder(string type)
    {
        this.type = type;
    }

    public CoffeBuilder SetPrice(float price)
    {
        this.price = price;
        return this;
    }
    public CoffeBuilder AddSugar(bool sugar = false)
    {
        this.sugar = sugar;
        return this;
    }
    public Coffee Build()
    {
        return new Coffee(this);
    }
}