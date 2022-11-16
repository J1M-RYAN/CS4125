using CS4125.Data.Finance;
using CS4125.Data.AnimalData;

namespace CS4125.Data.UserData;

// Concrete Observer
public class Farmer : User, IObserver
{
    public Tier tier;
    private readonly HashSet<Invoice> _invoices;
    private List<Site> _sites;

    public Farmer(string email, string firstName, string lastName, string password) : base(email, firstName, lastName,
        password)
    {
        _invoices = new HashSet<Invoice>();
        _sites = new List<Site>();
        tier = Tier.Bronze;
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

    public void AddInvoice(Invoice invoice)
    {
        _invoices.Add(invoice);
    }

    public List<Animal> Animals()
    {
        var animals = new List<Animal>();
        foreach (var site in _sites)
        {
            animals.AddRange(site.GetAnimals());
        }

        return animals;
    }

    public List<Site> Sites
    {
        get => _sites;
    }
}

public enum Tier
{
    Bronze,
    Silver,
    Gold
}