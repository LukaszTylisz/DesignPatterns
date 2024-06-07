namespace InterfaceSegregation.Bad;

public class HtpLaserJet : IPrinter
{
    public void PrintGrey(string content)
    {
        Console.WriteLine("HP Print gray");
    }

    public void PrintColor(string content)
    {
        Console.WriteLine("HP Print color");
    }

    public void Scan(string content)
    {
        Console.WriteLine("HP Print scan");
    }

    public void Fax(string content)
    {
        Console.WriteLine("HP Print fax");
    }
}