using CS4125.Data.AnimalData;

namespace CS4125.Data.UserData;

public class Site : ISite
{
    private readonly HashSet<AnimalData.Animal> _animals;
    private string _name;

    public Site(string name, Address address)
    {
        _name = name;
        _animals = new HashSet<AnimalData.Animal>();
    }

    public void AddAnimal(AnimalData.Animal animal)
    {
        _animals.Add(animal);
    }

    public void RemoveAnimal(AnimalData.Animal animal)
    {
        _animals.Remove(animal);
    }

    public void CreateAnimal(string animalType, string breed)
    {
        var animal = AnimalFactory.CreateAnimal(animalType, breed);
        AddAnimal(animal);
    }

    public HashSet<AnimalData.Animal> GetAnimals()
    {
        return _animals;
    }
}