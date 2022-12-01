namespace CS4125.Data.Finance.State;
using CS4125.Data.AnimalData;
using CS4125.Data.UserData;
//state pattern stuff
public class BronzeTierSub : State
{
    double _serviceFee;

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