using CS4125.Data;

namespace CS4125.Controllers;

public class SystemController
{
    public static readonly Data.System System = new();

    public static void AddSubscriber(IObserver f)
    {
        System.Attach(f);
    }


    public static void RemoveSubscriber(IObserver f)
    {
        System.Detach(f);
    }

    public void CreateInvoice()
    {
    }
}