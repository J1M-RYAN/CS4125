using CS4125.Data.AnimalData;
using CS4125.Data.UserData;
namespace CS4125.Data.Finance;
public abstract class InvoiceBase
{
    protected List<Animal> animals;
    protected List<Site> sites;

    public abstract double CalculateTotalInvoicePrice();

    private double BASE_BOVINE_PRICE = 0.7;
    private double BASE_OVINE_PRICE = 0.3;
    private double BASE_EQUINE_PRICE = 1;

    public double BASE_SITE_PRICE = 1.2;

    public double CalculateTotalAnimalPrice()
    {
        double total = 0;
        foreach (Animal animal in animals)
        {
            switch (animal)
            {
                case Bovine bovine:
                    total += getBovinePrice(bovine);
                    break;

                case Ovine ovine:
                    total += getOvinePrice(ovine);
                    break;
                case Equine equine:
                    total += getEquinePrice(equine);
                    break;
            }
        }

        return total;
    }

    public double CalculateTotalSitePrice()
    {
        double total = 0;
        foreach (Site site in sites)
        {
            total += BASE_SITE_PRICE;
        }
        return total;
    }

    private double getEquinePrice(Equine equine)
    {
        double price = BASE_EQUINE_PRICE;

        price = adjustPriceBasedOnSex(equine, price);

        switch (equine.Breed)
        {
            case EquineBreed.ARABIAN:
                price += 0.1;
                break;
            case EquineBreed.APPALOOSA:
                price += 0.2;
                break;
            case EquineBreed.BERKSHIRE:
                price += 0.3;
                break;
            case EquineBreed.BURGUNDY:

                price += 0.4;
                break;
            case EquineBreed.CHESTNUT:
                price += 0.5;
                break;
            case EquineBreed.CLEVELAND_BAY:
                price += 0.6;
                break;
            case EquineBreed.CREMELLO:
                price += 0.7;
                break;
            case EquineBreed.DAPPLE_GREY:
                price += 0.8;
                break;
            case EquineBreed.DUN:
                price += 0.9;
                break;
            case EquineBreed.GRAY:
                price += 1;
                break;
            case EquineBreed.GRULLA:
                price += 1.1;
                break;
            case EquineBreed.HAFLINGER:
                price += 1.2;
                break;
            case EquineBreed.HANOVERIAN:
                price += 1.3;
                break;
            case EquineBreed.JERSEY:
                price += 1.4;
                break;
            case EquineBreed.MUSTANG:
                price += 1.5;
                break;
            case EquineBreed.MORGAN:
                price += 1.6;
                break;
        }
        return price;

    }

    private double getOvinePrice(Ovine ovine)
    {
        double price = BASE_OVINE_PRICE;

        price = adjustPriceBasedOnSex(ovine, price);

        switch (ovine.Breed)
        {
            case OvineBreed.BROWN_SWISS:
                price += 0.1;
                break;

            case OvineBreed.CHEVIOT:
                price += 0.2;
                break;

            case OvineBreed.CORRIE:

                price += 0.3;
                break;

            case OvineBreed.EAST_FRIESIAN:
                price += 0.4;
                break;

            case OvineBreed.FINNISH_LANDRACE:
                price += 0.5;
                break;

            case OvineBreed.HAMPSHIRE:
                price += 0.6;
                break;
            case OvineBreed.HORNED_DORSET:
                price += 0.7;
                break;
            case OvineBreed.ILE_DE_FRANCE:
                price += 0.8;
                break;
            case OvineBreed.KERRY_HILL:
                price += 0.9;
                break;
            case OvineBreed.LINCOLN:
                price += 1;
                break;
            case OvineBreed.MANX_LOAGHTAN:
                price += 1.1;
                break;
            case OvineBreed.MONTBELIARDE:
                price += 1.2;
                break;
            case OvineBreed.NORFOLK_HORN:
                price += 1.3;
                break;
            case OvineBreed.NORWEGIAN_DALE:
                price += 1.4;
                break;
            case OvineBreed.POLLED_DORSET:
                price += 1.5;
                break;
            case OvineBreed.SHROPSHIRE:
                price += 1.6;
                break;
            case OvineBreed.SOUTH_DOWN:

                price += 1.7;
                break;
            case OvineBreed.TEXEL:

                price += 1.8;
                break;
            case OvineBreed.WELSH_MOUNTAIN:

                price += 1.9;
                break;
            case OvineBreed.WELSH_WHITE:

                price += 2;
                break;
            case OvineBreed.WEST_FRIESIAN:

                price += 2;
                break;
            case OvineBreed.YAKIMA:

                price += 2.1;
                break;
            default:
                price += 0.2;
                break;
        }
        return price;
    }

    private double getBovinePrice(Bovine bovine)
    {
        // Calculate price for bovine by sex, bovine_base_price, and breed

        double price = BASE_BOVINE_PRICE;

        price = adjustPriceBasedOnSex(bovine, price);

        switch (bovine.Breed)
        {
            case BovineBreed.HOLSTEIN:
                price *= 1.1;
                break;
            case BovineBreed.JERSEY:
                price *= 1.2;
                break;
            case BovineBreed.FRIESIAN:
                price *= 1.3;
                break;
            case BovineBreed.AYRSHIRE:
                price *= 1.4;
                break;
            case BovineBreed.GUERNSEY:
                price *= 1.5;
                break;
            case BovineBreed.RED:
                price *= 1.6;
                break;
            case BovineBreed.BROWN:
                price *= 1.7;
                break;
            case BovineBreed.WHITE:
                price *= 1.8;
                break;
            case BovineBreed.BLACK:
                price *= 1.9;
                break;
            case BovineBreed.HOLSTEIN_FRIESIAN:
                price *= 2;
                break;
            case BovineBreed.HOLSTEIN_JERSEY:
                price *= 2.1;
                break;
            case BovineBreed.HOLSTEIN_GUERNSEY:
                price *= 2.2;
                break;
            case BovineBreed.HOLSTEIN_AYRSHIRE:
                price *= 2.3;
                break;
            case BovineBreed.HOLSTEIN_RED:
                price *= 2.4;
                break;
            case BovineBreed.HOLSTEIN_BROWN:
                price *= 2.5;
                break;
            case BovineBreed.HOLSTEIN_WHITE:
                price *= 2.6;
                break;
            case BovineBreed.HOLSTEIN_BLACK:
                price *= 2.7;
                break;
            case BovineBreed.FRIESIAN_JERSEY:
                price *= 2.8;
                break;
            case BovineBreed.FRIESIAN_GUERNSEY:
                price *= 2.9;
                break;
            case BovineBreed.FRIESIAN_AYRSHIRE:
                price *= 3;
                break;
            case BovineBreed.FRIESIAN_RED:
                price *= 3.1;
                break;
        }

        return price;

    }


    public double adjustPriceBasedOnSex(Animal animal, double price)
    {
        if (animal.getSex() == Sex.Male)
        {
            price *= 1.1;
        }
        else
        {
            price *= 0.9;
        }
        return price;
    }

}