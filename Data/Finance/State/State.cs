using CS4125.Data.UserData;

namespace CS4125.Data.Finance.State;

public abstract class State
{
    protected internal double charge;
    protected internal Tier tier;
    protected internal Farmer farmer;

    public double Charge
    {
        get => charge;
        set => charge = value;
    }

    public Tier Tier
    {
        get => tier;
        set => tier = value;
    }

    public Farmer Farmer
    {
        get => farmer;
        set => farmer = value;
    }

    public abstract double CalculateTotalInvoicePrice(InvoiceBase invoice);


    public void Handle(Context context)
    {
        context.Request();
    }
}