namespace Prototype;

class Program
{
    static void Main(string[] args)
    {
        var person1 = new Person("Mahdi", "Gholami Pak", 21);
        person1.Introduce();
        var person2 = person1.DeepCopy();
        person2.Introduce();
    }
}

public class Person
{
    private string _name;
    private string _family;
    private int _age;
    public Person(string name, string family, int age)
    {
        _name = name;
        _family = family;
        _age = age;
    }
    public void Introduce()
    {
        System.Console.WriteLine($"I am {_name} {_family} and {_age} years old.");
    }
    public Person ShallowCopy()
    {
        return (Person)this.MemberwiseClone();
    }
    public Person DeepCopy()
    {
        var clone = (Person)this.MemberwiseClone();
        clone._name = this._name;
        clone._family = this._family;
        clone._age = this._age;
        return clone;
    }
}