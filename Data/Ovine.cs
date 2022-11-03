public abstract class Ovine : Animal
{
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

    private readonly OvineBreed _breed;
    private double _woolYield;

    public Ovine(int id, DateTime dob, Sex sex, OvineBreed _breed, double woolYield) : base(id, dob, sex)
    {
        this._breed = _breed;
        _woolYield = woolYield;
    }


    public double EstimatedWoolYield()
    {
        switch (_breed)
        {
            case OvineBreed.BROWN_SWISS:
                return 2.2;
            case OvineBreed.CHEVIOT:
                return 2.1;
            case OvineBreed.CORRIE:
                return 2.0;
            case OvineBreed.EAST_FRIESIAN:
                return 1.9;
            case OvineBreed.FINNISH_LANDRACE:
                return 1.8;
            case OvineBreed.HAMPSHIRE:
                return 1.7;
            case OvineBreed.HORNED_DORSET:
                return 1.6;
            case OvineBreed.ILE_DE_FRANCE:
                return 1.5;
            case OvineBreed.KERRY_HILL:
                return 1.4;
            case OvineBreed.LINCOLN:
                return 1.3;
            case OvineBreed.MANX_LOAGHTAN:
                return 1.2;
            case OvineBreed.MONTBELIARDE:
                return 1.1;
            case OvineBreed.NORFOLK_HORN:
                return 1.0;
            case OvineBreed.NORWEGIAN_DALE:
                return 3.1;
            case OvineBreed.POLLED_DORSET:
                return 3.0;
            case OvineBreed.SHROPSHIRE:
                return 3.1;
            case OvineBreed.SOUTH_DOWN:
                return 3.5;
            case OvineBreed.TEXEL:
                return 2.2;
            case OvineBreed.WELSH_MOUNTAIN:
                return 5.3;
            case OvineBreed.WELSH_WHITE:
                return 4.2;
            case OvineBreed.WEST_FRIESIAN:
                return 3.8;
            case OvineBreed.YAKIMA:
                return 2.6;
            default:
                return 0;
        }
    }
}