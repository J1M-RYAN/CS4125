using CS4125.Data.UserData;

namespace CS4125.Data.Finance;

public class Invoice
{
    private DateTime _date;

    private Farmer _farmer;

    private bool _paid;

    private double _total;

    private String _businessName;

    private Address _businessAddress;

    public Invoice(Farmer farmer, double total, String businessName, Address businessAddress)

    {
        _farmer = farmer;
        _total = total;
        _date = DateTime.Now;
        _paid = false;
        _businessAddress = businessAddress;
        _businessName = businessName;

    }

    public bool IsPaid()
    {
        return _paid;
    }

    public void Pay()
    {
        _paid = true;
    }
}