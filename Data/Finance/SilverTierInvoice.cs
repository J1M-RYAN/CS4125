using CS4125.Data.UserData;

namespace CS4125.Data.Finance;

public class SilverTierInvoice : InvoiceBase
{
    private const double SilverTierCharge = 0.15;

    public SilverTierInvoice(Farmer farmer)
    {
        Animals = farmer.Animals();

        Sites = farmer.Sites;
    }

    public override double CalculateTotalInvoicePrice()
    {
        return Math.Max(CalculateTotalAnimalPrice() + CalculateTotalSitePrice() - BaseSitePrice + SilverTierCharge,
            0);
    }
}