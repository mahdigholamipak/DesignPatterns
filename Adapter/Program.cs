namespace Adapter;

class Program
{
    static void Main(string[] args)
    {
        var wildDog = new WildDog();
        var wildDogAdapter = new WildDogAdapter(wildDog);
        var hunter = new Hunter();
        hunter.Hunt(wildDogAdapter);
    }
}

interface ILion
{
    void Roar();
}

class AfricanLion : ILion
{
    public void Roar()
    {
        System.Console.WriteLine("Roaaaaaar");
    }
}

class AsiaLion : ILion
{
    public void Roar()
    {
        System.Console.WriteLine("Roarrrrrrrrr");
    }
}

class Hunter
{
    public void Hunt(ILion lion)
    {
        lion.Roar();
    }
}

class WildDog
{
    public void bark()
    {
        System.Console.WriteLine("Barkkkkkkk");
    }
}

class WildDogAdapter : ILion
{
    private WildDog dog;
    public WildDogAdapter(WildDog dog)
    {
        this.dog = dog;
    }
    public void Roar()
    {
        dog.bark();
    }
}



