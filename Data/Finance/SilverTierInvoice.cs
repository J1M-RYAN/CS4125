using CS4125.Data.UserData;

namespace CS4125.Data.Finance;

public class SilverTierInvoice : InvoiceBase
{

    public SilverTierInvoice(Farmer farmer)
    {
        Animals = farmer.Animals();

        Sites = farmer.Sites;
    }


}