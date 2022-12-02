using CS4125.Controllers;
using CS4125.Data.Finance;
using CS4125.Data.UserData;

namespace CS4125.Data.System;

// Concrete Subject
public class System : IRegister, ISubject
{
    private readonly HashSet<IObserver> _paidSubscribers;
    private readonly HashSet<User> _users;
    private readonly CompanyData _companyData;

    private Dictionary<string, User> _userDictionary;

    public System()
    {
        _users = new HashSet<User>();
        _paidSubscribers = new HashSet<IObserver>();
        var address = new Address();
        _companyData = new CompanyData("Farm Ledger", address);
        _userDictionary = new Dictionary<string, User>();
    }


    public void RegisterFarmer(string email, string firstName, string lastName, string password)
    {
        var f = new Farmer(this, email, firstName, lastName);
        _users.Add(f);
    }

    public void Attach(IObserver observer)
    {
        _paidSubscribers.Add((Farmer)observer);
    }

    public void Detach(IObserver observer)
    {
        _paidSubscribers.Remove((Farmer)observer);
    }

    public void Notify()
    {
        foreach (var observer in _paidSubscribers) observer.Update(this);
    }

    public HashSet<User> GetUsers()
    {
        return _users;
    }

    public CompanyData GetCompanyData()
    {
        return _companyData;
    }

    public void AddUser(string id, string email)
    {
        var f = new Farmer(this, email, null, null);

        _userDictionary[id] = f;
        _users.Add(f);
        f.AddSite();
    }

    public User GetUser(string id)
    {
        return _userDictionary[id];
    }
    
    // Get all the farmers
    public List<Farmer> GetFarmers()
    {
        var farmers = new List<Farmer>();
        foreach (var user in _users)
        {
            if (user is Farmer)
            {
                farmers.Add((Farmer)user);
            }
        }

        return farmers;
    }
}