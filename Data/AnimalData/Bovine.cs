namespace CS4125.Data.AnimalData;

public abstract class Bovine : Animal
{
    public Bovine(int id, DateTime dob, Sex sex, BovineBreed _breed) : base(id, dob, sex)
    {
        Breed = _breed;
    }

    public BovineBreed Breed { get; }
}

public enum BovineBreed
{
    HOLSTEIN,
    JERSEY,
    FRIESIAN,
    AYRSHIRE,
    GUERNSEY,
    RED,
    BROWN,
    WHITE,
    BLACK,
    HOLSTEIN_FRIESIAN,
    HOLSTEIN_JERSEY,
    HOLSTEIN_GUERNSEY,
    HOLSTEIN_AYRSHIRE,
    HOLSTEIN_RED,
    HOLSTEIN_BROWN,
    HOLSTEIN_WHITE,
    HOLSTEIN_BLACK,
    FRIESIAN_JERSEY,
    FRIESIAN_GUERNSEY,
    FRIESIAN_AYRSHIRE,
    FRIESIAN_RED,
    FRIESIAN_BROWN,
    FRIESIAN_WHITE,
    FRIESIAN_BLACK,
    JERSEY_GUERNSEY,
    JERSEY_AYRSHIRE,
    JERSEY_RED,
    JERSEY_BROWN,
    JERSEY_WHITE,
    JERSEY_BLACK,
    GUERNSEY_AYRSHIRE,
    GUERNSEY_RED,
    GUERNSEY_BROWN,
    GUERNSEY_WHITE,
    GUERNSEY_BLACK,
    AYRSHIRE_RED,
    AYRSHIRE_BROWN,
    AYRSHIRE_WHITE,
    AYRSHIRE_BLACK,
    RED_BROWN,
    RED_WHITE,
    RED_BLACK,
    BROWN_WHITE,
    BROWN_BLACK,
    WHITE_BLACK
}