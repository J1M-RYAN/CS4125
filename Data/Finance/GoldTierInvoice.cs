namespace CS4125.Data.Finance;

public class GoldTierInvoice : InvoiceDecorator
{
    public GoldTierInvoice(InvoiceBase invoice)
        : base(invoice)
    {
    }

}