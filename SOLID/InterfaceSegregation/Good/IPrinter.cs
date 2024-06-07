namespace InterfaceSegregation.Good;

public interface IPrinter
{
    void PrintGrey(string content);
    void PrintColor(string content);
}

public interface IScanner
{
    void Scan(string content);
}

public interface IFax
{
    void Fax(string content);
}