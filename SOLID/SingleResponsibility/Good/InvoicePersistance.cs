using SingleResponsibility.Bad;

namespace SingleResponsibility.Good;

public class InvoicePersistance
{
    private Invoice _invoice;

    public InvoicePersistance(Invoice invoice)
    {
        _invoice = invoice;
    }
    
    public void SaveToPDF()
    {
        Console.WriteLine("Saving to PDF");
    }
}