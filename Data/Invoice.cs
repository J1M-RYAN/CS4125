using CS4125.Data;

public class Invoice
{
    private DateTime _date;

    private Farmer _farmer;

    private bool _paid;

    private double _total;

    public Invoice(Farmer farmer, double total)

    {
        _farmer = farmer;
        _total = total;
        _date = DateTime.Now;
        _paid = false;
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