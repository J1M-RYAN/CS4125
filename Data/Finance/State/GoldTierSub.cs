namespace CS4125.Data.Finance.State;

//state pattern stuff
public class GoldTierSub : State
{
    Invoice tempInvoice;
    private double _serviceFee;
    private double originalPrice;
    private static double originalprice;

    public GoldTierSub(State state)
    {
        Initialize();
    }
    private void Initialize()
    {
        _serviceFee = 10;
        originalPrice = 0;
    }
    
 
    //import an invoice
    public static Invoice ImportInvoice(Invoice invoice, InvoiceBase invoiceBase, double invoiceTotal)
    { 
        invoice._total=invoiceTotal+invoice._total;
        originalprice=invoice._total;
        return invoice;
    }
    
    
    public override double CalculateTotalInvoicePrice(InvoiceBase invoiceBase)
    {
        originalprice *= 0.75;
        return originalprice + _serviceFee;
    }
}