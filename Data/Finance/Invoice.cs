using CS4125.Data.UserData;

namespace CS4125.Data.Finance;

public class Invoice
{
    public Address _businessAddress;

    public string _businessName;
    public DateTime _date;

    public Farmer _farmer;

    public bool _paid;

    public double _total;

    public Invoice(Farmer farmer, double total, string businessName, Address businessAddress)

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
    
    public double GetTotal()
    {
        return _total;
    }
    
}