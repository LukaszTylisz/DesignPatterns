using OpenClose.Bad;

namespace OpenClose.Good;

public class WordInvoiceSaver : IInvoiceSaver
{
    public void Save(Invoice invoice)
    {
        Console.WriteLine("Saving as Word");
    }
}