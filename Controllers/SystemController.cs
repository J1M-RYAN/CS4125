using CS4125.Data;

namespace CS4125.Controllers;

public class SystemController
{
    public static readonly Data.System _system = new();

    public static void AddSubscriber(Farmer f)
    {
        _system._paidSubscribers.Add(f);
    }


    public static void RemoveSubscriber(Farmer f)
    {
        _system._paidSubscribers.Remove(f);
    }

    public void CreateInvoice()
    {
    }
}