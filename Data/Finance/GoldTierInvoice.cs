using CS4125.Data.AnimalData;
using CS4125.Data.Finance.State;

namespace CS4125.Data.Finance;

public class GoldTierInvoice : InvoiceDecorator
{
    public GoldTierInvoice(InvoiceBase invoice) : base(invoice)
    {
        
    }
}