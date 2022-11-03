using CS4125.Controllers;

namespace CS4125.Data;

// Concrete Subject
public class System : IRegister, ISubject
{
    public System()
    {
        Users = new HashSet<User>();
        PaidSubscribers = new HashSet<Farmer>();
    }

    public HashSet<User> Users { get; set; }

    public HashSet<Farmer> PaidSubscribers { get; set; }

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
}