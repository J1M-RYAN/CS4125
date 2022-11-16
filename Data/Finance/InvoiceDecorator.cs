namespace CS4125.Data.Finance;

public class InvoiceDecorator : InvoiceBase
{
    protected InvoiceBase invoice;

    public InvoiceDecorator(InvoiceBase invoice)
    {
        this.invoice = invoice;
    }

    public override double CalculateTotalInvoicePrice()
    {
        return invoice.CalculateTotalInvoicePrice();
    }
}