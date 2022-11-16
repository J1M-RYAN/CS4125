using CS4125.Controllers;
using CS4125.Data.Finance;
using CS4125.Data.UserData;

namespace CS4125.Data.System;

// Concrete Subject
public class System : IRegister, ISubject
{
    private readonly HashSet<IObserver> PaidSubscribers;
    private readonly HashSet<User> Users;

    public System()
    {
        Users = new HashSet<User>();
        PaidSubscribers = new HashSet<IObserver>();
    }


    public void RegisterFarmer(string email, string firstName, string lastName, string password)
    {
        var f = new Farmer(email, firstName, lastName, password);
        Users.Add(f);
    }

    public void Attach(IObserver observer)
    {
        PaidSubscribers.Add((Farmer)observer);
    }

    public void Detach(IObserver observer)
    {
        PaidSubscribers.Remove((Farmer)observer);
    }

    public void Notify()
    {
        foreach (var observer in PaidSubscribers) observer.Update();
    }

    public HashSet<User> GetUsers()
    {
        return Users;
    }


}