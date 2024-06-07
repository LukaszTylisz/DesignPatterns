namespace OpenClose.Bad;

public class InvoiceLogger
{
    private Invoice _invoice;

    public InvoiceLogger(Invoice invoice)
    {
        _invoice = invoice;
    }
    
    public void Display()
    {
        Console.WriteLine($"Vende: {_invoice.Vendor}");
        Console.WriteLine($"Vende: {_invoice.Vendee}");
        Console.WriteLine($"Total: {_invoice.Total}");
    }
}