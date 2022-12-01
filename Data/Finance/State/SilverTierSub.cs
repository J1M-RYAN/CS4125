namespace CS4125.Data.Finance.State;

//state pattern stuff
public class SilverTierSub : State
{
    private double _serviceFee;

    // Constructor
    public SilverTierSub(State state)
    {
        Initialize();
    }

    private void Initialize()
    {
        _serviceFee = 15;
    }

    public override double CalculateTotalInvoicePrice(InvoiceBase invoice)
    {
        return invoice.CalculateTotalAnimalPrice() + invoice.CalculateTotalSitePrice() + _serviceFee;
    }
}