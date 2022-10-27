using System.Net.Sockets;

namespace CS4125.Data;

public class Site
{
    private string name;
    private Address _address;
    
    HashSet<Animal> _animals = new HashSet<Animal>();

    public Site(string name, Address address)
    {
        this.name = name;
        _address = address;
    }
}
