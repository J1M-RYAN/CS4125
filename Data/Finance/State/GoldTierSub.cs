namespace CS4125.Data.Finance.State;

//state pattern stuff
public class GoldTierSub : State
{
    private double _serviceFee;
    public GoldTierSub(State state)
    {
        Initialize();
    }
    private void Initialize()
    {
        _serviceFee = 10;
    }
    public override double CalculateTotalInvoicePrice(InvoiceBase invoice)
    {
        var invoiceBasePrice = invoice.CalculateBasePrice();
        invoiceBasePrice *= 0.75;
        return invoiceBasePrice + _serviceFee;
    }
}