namespace CS4125.Data.Finance;
using CS4125.Data.UserData;
public class BronzeTierInvoice : InvoiceBase
{
    double BronzeTierCharge = 0.1;
    public override double CalculateTotalInvoicePrice()
    {
        return CalculateTotalAnimalPrice() + CalculateTotalSitePrice() + BronzeTierCharge;
    }
    public BronzeTierInvoice(Farmer farmer)
    {
        this.animals = farmer.Animals();

        this.sites = farmer.Sites;
    }
}