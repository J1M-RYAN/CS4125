using CS4125.Data.UserData;

namespace CS4125.Data.Finance;

public class BronzeTierInvoice : InvoiceBase
{
    private const double BronzeTierCharge = 0.1;

    public BronzeTierInvoice(Farmer farmer)
    {
        animals = farmer.Animals();

        sites = farmer.Sites;
    }

    public override double CalculateTotalInvoicePrice()
    {
        return CalculateTotalAnimalPrice() + CalculateTotalSitePrice() + BronzeTierCharge;
    }
}