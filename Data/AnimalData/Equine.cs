namespace CS4125.Data.AnimalData;

public abstract class Equine : Animal
{
    private EquineBreed _breed;

    public EquineBreed Breed => _breed;

    public Equine(int id, DateTime dob, Sex sex, EquineBreed _breed) : base(id, dob, sex)
    {
        this._breed = _breed;
    }
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
    MORGAN,
}