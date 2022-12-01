namespace CS4125.Data.Finance;

public class InvoiceDecorator : InvoiceBase
{
    protected InvoiceBase Invoice;

    public InvoiceDecorator(InvoiceBase invoice)
    {
        Invoice = invoice;
    }
}