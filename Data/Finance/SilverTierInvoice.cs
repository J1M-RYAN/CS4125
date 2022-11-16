namespace CS4125.Data.Finance;
using CS4125.Data.UserData;


public class SilverTierInvoice : InvoiceBase
{
    double SilverTierCharge = 0.15;
    public override double CalculateTotalInvoicePrice()
    {
        return Math.Max(CalculateTotalAnimalPrice() + CalculateTotalSitePrice() - BASE_SITE_PRICE + SilverTierCharge, 0);
    }
    public SilverTierInvoice(Farmer farmer)
    {
        this.animals = farmer.Animals();

        this.sites = farmer.Sites;
    }
}