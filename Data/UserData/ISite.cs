using CS4125.Data.AnimalData;

namespace CS4125.Data.UserData;

public interface ISite
{
    void AddAnimal(Animal animal);
    void RemoveAnimal(Animal animal);
}