namespace InterfaceSegregation.Bad;

public class Canon : IPrinter
{
    public void PrintGrey(string content)
    {
        Console.WriteLine("Canon Print gray");
    }

    public void PrintColor(string content)
    {
        Console.WriteLine("Canon Print color");
    }

    public void Scan(string content)
    {
        throw new NotImplementedException();
    }

    public void Fax(string content)
    {
        Console.WriteLine("Canon Print Fax");
    }
}