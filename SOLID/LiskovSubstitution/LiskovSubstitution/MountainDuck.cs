namespace LiskovSubstitution;

public class MountainDuck : Duck
{
    public override void Swim()
    {
        Console.WriteLine("Mountain duck Swim");
    }

    public override void Quack()
    {
        Console.WriteLine("Mountain duck Quack");
    }

    public override void Fly()
    {
        Console.WriteLine("Mountain duck flies");
    }
}