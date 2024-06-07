namespace InterfaceSegregation.Bad;

public interface IPrinter
{
    void PrintGrey(string content);
    void PrintColor(string content);
    void Scan(string content);
    void Fax(string content);
}