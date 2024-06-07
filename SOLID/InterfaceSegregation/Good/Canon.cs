namespace InterfaceSegregation.Good;

public class Canon : IPrinter, IFax
{
    public void PrintGrey(string content)
    {
        Console.WriteLine("Canon Print gray");
    }

    public void PrintColor(string content)
    {
        Console.WriteLine("Canon Print color");
    }

    public void Fax(string content)
    {
        Console.WriteLine("Canon Print Fax");
    }
}