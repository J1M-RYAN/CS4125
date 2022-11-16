using CS4125.Data.Animal;

namespace CS4125.Data.UserData;

public class Site : ISite
{
    private readonly HashSet<Animal.Animal> _animals;
    private string _name;

    public Site(string name, Address address)
    {
        _name = name;
        _animals = new HashSet<Animal.Animal>();
    }

    public void AddAnimal(Animal.Animal animal)
    {
        _animals.Add(animal);
    }

    public void RemoveAnimal(Animal.Animal animal)
    {
        _animals.Remove(animal);
    }

    public void CreateAnimal(string animalType, string breed)
    {
        var animal = AnimalFactory.CreateAnimal(animalType, breed);
        AddAnimal(animal);
    }
}