namespace CS4125.Data.Finance;
public class GoldTierInvoice : InvoiceDecorator
{
    double GoldTierCharge = 0.2;
    public GoldTierInvoice(InvoiceBase invoice)
        : base(invoice)
    {
    }

    public override double CalculateTotalInvoicePrice()
    {
        var invoiceBasePrice = base.CalculateTotalInvoicePrice();

        invoiceBasePrice *= 0.75;

        return invoiceBasePrice + GoldTierCharge;
    }
}