using CS4125.Data.UserData;

namespace CS4125.Data.System;

public class CompanyData
{
    private readonly Address _address;
    private string _name;

    public CompanyData(string name, Address address)
    {
        _name = name;
        _address = _address;
    }

    public string getName()
    {
        return _name;
    }

    public void setName(string name)
    {
        _name = name;
    }

    public Address getAddress()
    {
        return _address;
    }
}