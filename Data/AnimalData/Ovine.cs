namespace CS4125.Data.AnimalData;

public abstract class Ovine : Animal
{
    private double _woolYield;

    public Ovine(int id, DateTime dob, Sex sex, OvineBreed breed, double woolYield) : base(id, dob, sex)
    {
        Breed = breed;
        _woolYield = woolYield;
    }

    public OvineBreed Breed { get; }


    public double EstimatedWoolYield()
    {
        return Breed switch
        {
            OvineBreed.BrownSwiss => 2.2,
            OvineBreed.Cheviot => 2.1,
            OvineBreed.Corrie => 2.0,
            OvineBreed.EastFriesian => 1.9,
            OvineBreed.FinnishLandrace => 1.8,
            OvineBreed.Hampshire => 1.7,
            OvineBreed.HornedDorset => 1.6,
            OvineBreed.IleDeFrance => 1.5,
            OvineBreed.KerryHill => 1.4,
            OvineBreed.Lincoln => 1.3,
            OvineBreed.ManxLoaghtan => 1.2,
            OvineBreed.Montbeliarde => 1.1,
            OvineBreed.NorfolkHorn => 1.0,
            OvineBreed.NorwegianDale => 3.1,
            OvineBreed.PolledDorset => 3.0,
            OvineBreed.Shropshire => 3.1,
            OvineBreed.SouthDown => 3.5,
            OvineBreed.Texel => 2.2,
            OvineBreed.WelshMountain => 5.3,
            OvineBreed.WelshWhite => 4.2,
            OvineBreed.WestFriesian => 3.8,
            OvineBreed.Yakima => 2.6,
            _ => 0
        };
    }
}

public enum OvineBreed
{
    BrownSwiss,
    Cheviot,
    Corrie,
    EastFriesian,
    FinnishLandrace,
    Hampshire,
    HornedDorset,
    IleDeFrance,
    KerryHill,
    Lincoln,
    ManxLoaghtan,
    Montbeliarde,
    NorfolkHorn,
    NorwegianDale,
    PolledDorset,
    Shropshire,
    SouthDown,
    Texel,
    WelshMountain,
    WelshWhite,
    WestFriesian,
    Yakima
}