namespace CS4125.Data.Finance.State;
using CS4125.Data.AnimalData;
using CS4125.Data.UserData;
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