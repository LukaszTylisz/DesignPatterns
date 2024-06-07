using OpenClose.Bad;

namespace OpenClose.Good;

public interface IInvoiceSaver
{
    void Save(Invoice invoice);
}