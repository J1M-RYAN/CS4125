using CS4125.Data.AnimalData;
using CS4125.Data.Finance;
using CS4125.Data.Finance.State;
using CS4125.Data.System;

namespace CS4125.Data.UserData;

// Concrete Observer
public class Farmer : User, IObserver
{
    private readonly HashSet<Invoice> _invoices;
    private System.System subject;
    public Tier Tier;

    public Farmer(System.System subject, string email, string firstName, string lastName, string password) : base(email, firstName, lastName,
        password)
    {
        _invoices = new HashSet<Invoice>();
        Sites = new List<Site>();
        Tier = Tier.Bronze;
        this.subject = subject;
    }

    public List<Site> Sites { get; }
    
    public State state;

    public void Update(ISubject subject)
    {
        System.System system = subject as System.System; 
        _invoices.Add(new Invoice(this, 25, system.GetCompanyData().getName(), system.GetCompanyData().getAddress()));
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

    public Invoice GetInvoiceToPay()
    {
        
        foreach (var invoice in _invoices)
        {
            if (!invoice.IsPaid())
            {
                return invoice;
            }
        }

        return null;
        
    }
}

public enum Tier
{
    Bronze,
    Silver,
    Gold
}