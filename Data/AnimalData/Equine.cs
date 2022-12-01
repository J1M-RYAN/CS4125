namespace CS4125.Data.AnimalData;

public abstract class Equine : Animal
{
    public Equine(int id, DateTime dob, Sex sex, EquineBreed breed) : base(id, dob, sex)
    {
        Breed = breed;
    }

    public EquineBreed Breed { get; }
}

public enum EquineBreed
{
    Arabian,
    Appaloosa,
    Berkshire,
    Burgundy,
    Chestnut,
    ClevelandBay,
    Cremello,
    DappleGrey,
    Dun,
    Gray,
    Grulla,
    Haflinger,
    Hanoverian,
    Jersey,
    Mustang,
    Morgan
}