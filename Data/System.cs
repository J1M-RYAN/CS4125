using CS4125.Controllers;

namespace CS4125.Data;

public class System : IRegister
{
    public System()
    {
        _users = new HashSet<User>();
        _paidSubscribers = new HashSet<Farmer>();
    }

    public HashSet<User> _users { get; set; }

    public HashSet<Farmer> _paidSubscribers { get; set; }

    public void RegisterFarmer(string email, string firstName, string lastName, string password)
    {
        var f = new Farmer(email, firstName, lastName, password);
        _users.Add(f);
    }
}