namespace OpenClose.Bad;

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
    
    public void SaveToWord()
    {
        Console.WriteLine("Saving to Word");
    }
}