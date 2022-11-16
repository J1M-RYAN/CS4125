namespace CS4125.Data.AnimalData;

public abstract class Equine : Animal
{
    public Equine(int id, DateTime dob, Sex sex, EquineBreed _breed) : base(id, dob, sex)
    {
        Breed = _breed;
    }

    public EquineBreed Breed { get; }
}

public enum EquineBreed
{
    ARABIAN,
    APPALOOSA,
    BERKSHIRE,
    BURGUNDY,
    CHESTNUT,
    CLEVELAND_BAY,
    CREMELLO,
    DAPPLE_GREY,
    DUN,
    GRAY,
    GRULLA,
    HAFLINGER,
    HANOVERIAN,
    JERSEY,
    MUSTANG,
    MORGAN
}