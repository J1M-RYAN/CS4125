namespace CS4125.Data.AnimalData;

public abstract class Ovine : Animal
{
    private readonly OvineBreed _breed;
    private double _woolYield;

    public Ovine(int id, DateTime dob, Sex sex, OvineBreed _breed, double woolYield) : base(id, dob, sex)
    {
        this._breed = _breed;
        _woolYield = woolYield;
    }

    public OvineBreed Breed => _breed;


    public double EstimatedWoolYield()
    {
        return _breed switch
        {
            OvineBreed.BROWN_SWISS => 2.2,
            OvineBreed.CHEVIOT => 2.1,
            OvineBreed.CORRIE => 2.0,
            OvineBreed.EAST_FRIESIAN => 1.9,
            OvineBreed.FINNISH_LANDRACE => 1.8,
            OvineBreed.HAMPSHIRE => 1.7,
            OvineBreed.HORNED_DORSET => 1.6,
            OvineBreed.ILE_DE_FRANCE => 1.5,
            OvineBreed.KERRY_HILL => 1.4,
            OvineBreed.LINCOLN => 1.3,
            OvineBreed.MANX_LOAGHTAN => 1.2,
            OvineBreed.MONTBELIARDE => 1.1,
            OvineBreed.NORFOLK_HORN => 1.0,
            OvineBreed.NORWEGIAN_DALE => 3.1,
            OvineBreed.POLLED_DORSET => 3.0,
            OvineBreed.SHROPSHIRE => 3.1,
            OvineBreed.SOUTH_DOWN => 3.5,
            OvineBreed.TEXEL => 2.2,
            OvineBreed.WELSH_MOUNTAIN => 5.3,
            OvineBreed.WELSH_WHITE => 4.2,
            OvineBreed.WEST_FRIESIAN => 3.8,
            OvineBreed.YAKIMA => 2.6,
            _ => 0
        };
    }
}

public enum OvineBreed
{
    BROWN_SWISS,
    CHEVIOT,
    CORRIE,
    EAST_FRIESIAN,
    FINNISH_LANDRACE,
    HAMPSHIRE,
    HORNED_DORSET,
    ILE_DE_FRANCE,
    KERRY_HILL,
    LINCOLN,
    MANX_LOAGHTAN,
    MONTBELIARDE,
    NORFOLK_HORN,
    NORWEGIAN_DALE,
    POLLED_DORSET,
    SHROPSHIRE,
    SOUTH_DOWN,
    TEXEL,
    WELSH_MOUNTAIN,
    WELSH_WHITE,
    WEST_FRIESIAN,
    YAKIMA
}