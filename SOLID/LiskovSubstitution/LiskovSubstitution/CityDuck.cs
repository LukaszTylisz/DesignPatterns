namespace LiskovSubstitution;

public class CityDuck : Duck
{
    public override void Swim()
    {
        Console.WriteLine("City duck Swim");
    }

    public override void Quack()
    {
        Console.WriteLine("City duck Quack");
    }

    public override void Fly()
    {
        Console.WriteLine("City duck flies");
    }
}