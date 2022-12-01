using CS4125.Data.UserData;

namespace CS4125.Data.System;

public class CompanyData
{
    private string _name;
    private Address _address;
    public CompanyData(string name, Address address)
    {
        this._name = name;
        this._address = _address;
    }

    public String getName()
    {
        return this._name;
    }

    public void setName(String name)
    {
        this._name = name;
    }

    public Address getAddress()
    {
        return this._address;
    }
    
    
}