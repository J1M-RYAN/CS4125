using CS4125.Data.AnimalData;
using CS4125.Data.Finance;

namespace CS4125.Data.UserData;

// Concrete Observer
public class Farmer : User, IObserver
{
    private readonly HashSet<Invoice> _invoices;
    public Tier tier;

    public Farmer(string email, string firstName, string lastName, string password) : base(email, firstName, lastName,
        password)
    {
        _invoices = new HashSet<Invoice>();
        Sites = new List<Site>();
        tier = Tier.Bronze;
    }

    public List<Site> Sites { get; }

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
        foreach (var site in Sites) animals.AddRange(site.GetAnimals());

        return animals;
    }
}

public enum Tier
{
    Bronze,
    Silver,
    Gold
}