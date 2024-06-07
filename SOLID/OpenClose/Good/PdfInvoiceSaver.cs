using OpenClose.Bad;

namespace OpenClose.Good;

public class PdfInvoiceSaver : IInvoiceSaver
{
    public void Save(Invoice invoice)
    {
        Console.WriteLine("Saving as PDF");
    }
}