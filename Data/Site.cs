

using CS4125.Data;
public class Site : ISite
{
    private HashSet<Animal> _animals;
    private string _name;

    public Site(string name, Address address)
    {
        this._name = name;
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
        Animal animal = AnimalFactory.CreateAnimal(animalType, breed);
        AddAnimal(animal);
    }

}