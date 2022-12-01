using CS4125.Data.UserData;

namespace CS4125.Data.Finance;

public class BronzeTierInvoice : InvoiceBase
{

    public BronzeTierInvoice(Farmer farmer)
    {
        Animals = farmer.Animals();

        Sites = farmer.Sites;
    }
    
}