using CS4125.Data.AnimalData;

namespace CS4125.Data.UserData;

public class Site : ISite
{
    private readonly HashSet<Animal> _animals;
    private string _name;
    private int _capacity =100;
    
    

    public Site(string name, Address address)
    {
        _name = name;
        _animals = new HashSet<Animal>();
    }

    public void AddAnimal(Animal animal)
    {
        _animals.Add(animal);
    }

    public void RemoveAnimal(Animal animal)
    {
        _animals.Remove(animal);
    }

    public void CreateAnimal(string animalType, string breed)
    {
        var animal = AnimalFactory.CreateAnimal(animalType, breed);
        AddAnimal(animal);
    }

    public IEnumerable<Animal> GetAnimals()
    {
        return _animals;
    }

    public int GetAnimalCount()
    {
        return _animals.Count;
    }
    
    public int GetRemainingCapacity()
    {
        var remainingCapacity = _capacity - _animals.Count;
        return remainingCapacity;
    }
}