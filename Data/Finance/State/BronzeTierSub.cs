namespace CS4125.Data.Finance.State;

//state pattern stuff
public class BronzeTierSub : State
{
    private double _serviceFee;

    // Constructor
    public BronzeTierSub(State state)
    {
        Initialize();
    }

    private void Initialize()
    {
        _serviceFee = 10;
    }

    public override double CalculateTotalInvoicePrice(InvoiceBase invoice)
    {
        return invoice.CalculateTotalAnimalPrice() + invoice.CalculateTotalSitePrice() + _serviceFee;
    }
}