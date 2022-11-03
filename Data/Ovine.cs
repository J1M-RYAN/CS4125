public abstract class Ovine : Animal
{
    private OvineBreed _breed;
    private double _woolYield;

    public Ovine(int id, DateTime dob, Sex sex, OvineBreed _breed) : base(id, dob, sex)
    {
        this._breed = _breed;
    }




public double estimatedWoolYield()
{
    //need business logic here

    switch (this._breed)
    {
        case OvineBreed.BROWN_SWISS:
            return 2.2;
        case OvineBreed.CHEVIOT:
            return 2.1;
        case OvineBreed.CORRIE:
            return 2.0;
        default:
            return 0;        
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
}