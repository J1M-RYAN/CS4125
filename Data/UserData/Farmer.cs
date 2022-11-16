using CS4125.Data.Finance;

namespace CS4125.Data.UserData;

// Concrete Observer
public class Farmer : User, IObserver
{
    private readonly HashSet<Invoice> _invoices;

    public Farmer(string email, string firstName, string lastName, string password) : base(email, firstName, lastName,
        password)
    {
        _invoices = new HashSet<Invoice>();
    }

    public void Update()
    {
        _invoices.Add(new Invoice(this, 25));
    }

    public void PayInvoice(Invoice invoice)
    {
        invoice.Pay();
    }

    public HashSet<Invoice> GetInvoices()
    {
        return _invoices;
    }
}