namespace CS4125.Data.AnimalData;

public abstract class Bovine : Animal
{
    public Bovine(int id, DateTime dob, Sex sex, BovineBreed breed) : base(id, dob, sex)
    {
        Breed = breed;
    }

    public BovineBreed Breed { get; }
}

public enum BovineBreed
{
    Holstein,
    Jersey,
    Friesian,
    Ayrshire,
    Guernsey,
    Red,
    Brown,
    White,
    Black,
    HolsteinFriesian,
    HolsteinJersey,
    HolsteinGuernsey,
    HolsteinAyrshire,
    HolsteinRed,
    HolsteinBrown,
    HolsteinWhite,
    HolsteinBlack,
    FriesianJersey,
    FriesianGuernsey,
    FriesianAyrshire,
    FriesianRed,
    FriesianBrown,
    FriesianWhite,
    FriesianBlack,
    JerseyGuernsey,
    JerseyAyrshire,
    JerseyRed,
    JerseyBrown,
    JerseyWhite,
    JerseyBlack,
    GuernseyAyrshire,
    GuernseyRed,
    GuernseyBrown,
    GuernseyWhite,
    GuernseyBlack,
    AyrshireRed,
    AyrshireBrown,
    AyrshireWhite,
    AyrshireBlack,
    RedBrown,
    RedWhite,
    RedBlack,
    BrownWhite,
    BrownBlack,
    WhiteBlack
}