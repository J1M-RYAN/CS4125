using System.Net.Sockets;

namespace CS4125.Data;

public class Site
{
    private string _name;
    private Address _address;

    private HashSet<Animal> _animals = new HashSet<Animal>();

    public Site(string name, Address address)
    {
        this._name = name;
        _address = address;
    }
}
