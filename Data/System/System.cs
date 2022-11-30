using CS4125.Controllers;
using CS4125.Data.Finance;
using CS4125.Data.UserData;

namespace CS4125.Data.System;

// Concrete Subject
public class System : IRegister, ISubject
{
    private readonly HashSet<IObserver> _paidSubscribers;
    private readonly HashSet<User> _users;

    public System()
    {
        _users = new HashSet<User>();
        _paidSubscribers = new HashSet<IObserver>();
    }


    public void RegisterFarmer(string email, string firstName, string lastName, string password)
    {
        var f = new Farmer(email, firstName, lastName, password);
        _users.Add(f);
    }

    public void Attach(IObserver observer)
    {
        _paidSubscribers.Add((Farmer) observer);
    }

    public void Detach(IObserver observer)
    {
        _paidSubscribers.Remove((Farmer) observer);
    }

    public void Notify()
    {
        foreach (var observer in _paidSubscribers) observer.Update();
    }

    public HashSet<User> GetUsers()
    {
        return _users;
    }
}