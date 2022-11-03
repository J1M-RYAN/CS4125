using CS4125.Data;

namespace CS4125.Controllers;

public class SystemController
{
    public static readonly Data.System System = new();

    public static void AddSubscriber(IObserver f)
    {
        System.PaidSubscribers.Add(f);
    }


    public static void RemoveSubscriber(IObserver f)
    {
        System.PaidSubscribers.Remove(f);
    }

    public void CreateInvoice()
    {
    }
}