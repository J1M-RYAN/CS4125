using System.Diagnostics.Contracts;
using CS4125.Data.AnimalData;

namespace CS4125.Data.UserData;

public class Site : ISite
{
    private readonly HashSet<Animal> _animals;
    private string _name;
    private static int MAX_ANIMALS = 50;
    
    

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
        Contract.Requires(_animals.Count < MAX_ANIMALS);
        var animalCountBefore = _animals.Count;
        var animal = AnimalFactory.CreateAnimal(animalType, breed);
        AddAnimal(animal);
        Contract.Ensures(_animals.Count == animalCountBefore + 1);
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
        var remainingCapacity = MAX_ANIMALS - _animals.Count;
        return remainingCapacity;
    }
    
    
    //list of all objects in all 
    public IEnumerable<Animal> GetAnimalsByType(string animalType)
    {
        var animals = _animals.Where(a => a.GetType().Name == animalType);
        return animals;
    }
    
    
}