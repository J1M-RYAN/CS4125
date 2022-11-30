using CS4125.Data.AnimalData;
using CS4125.Data.UserData;

namespace CS4125.Data.Finance;

public abstract class InvoiceBase
{
    protected const double BaseSitePrice = 1.2;

    private const double BaseBovinePrice = 0.7;
    private const double BaseEquinePrice = 1;
    private const double BaseOvinePrice = 0.3;
    protected List<Animal> Animals = null!;
    protected List<Site> Sites = null!;

    public abstract double CalculateTotalInvoicePrice();

    protected double CalculateTotalAnimalPrice()
    {
        double total = 0;
        foreach (var animal in Animals)
            switch (animal)
            {
                case Bovine bovine:
                    total += GetBovinePrice(bovine);
                    break;

                case Ovine ovine:
                    total += GetOvinePrice(ovine);
                    break;
                case Equine equine:
                    total += GetEquinePrice(equine);
                    break;
            }

        return total;
    }

    protected double CalculateTotalSitePrice()
    {
        return Sites.Sum(site => BaseSitePrice);
    }

    private static double GetEquinePrice(Equine equine)
    {
        var price = BaseEquinePrice;

        price = adjustPriceBasedOnSex(equine, price);

        price += equine.Breed switch
        {
            EquineBreed.Arabian => 0.1,
            EquineBreed.Appaloosa => 0.2,
            EquineBreed.Berkshire => 0.3,
            EquineBreed.Burgundy => 0.4,
            EquineBreed.Chestnut => 0.5,
            EquineBreed.ClevelandBay => 0.6,
            EquineBreed.Cremello => 0.7,
            EquineBreed.DappleGrey => 0.8,
            EquineBreed.Dun => 0.9,
            EquineBreed.Gray => 1,
            EquineBreed.Grulla => 1.1,
            EquineBreed.Haflinger => 1.2,
            EquineBreed.Hanoverian => 1.3,
            EquineBreed.Jersey => 1.4,
            EquineBreed.Mustang => 1.5,
            EquineBreed.Morgan => 1.6,
            _ => 0
        };
        return price;
    }

    private static double GetOvinePrice(Ovine ovine)
    {
        var price = BaseOvinePrice;

        price = adjustPriceBasedOnSex(ovine, price);

        price += ovine.Breed switch
        {
            OvineBreed.BrownSwiss => 0.1,
            OvineBreed.Cheviot => 0.2,
            OvineBreed.Corrie => 0.3,
            OvineBreed.EastFriesian => 0.4,
            OvineBreed.FinnishLandrace => 0.5,
            OvineBreed.Hampshire => 0.6,
            OvineBreed.HornedDorset => 0.7,
            OvineBreed.IleDeFrance => 0.8,
            OvineBreed.KerryHill => 0.9,
            OvineBreed.Lincoln => 1,
            OvineBreed.ManxLoaghtan => 1.1,
            OvineBreed.Montbeliarde => 1.2,
            OvineBreed.NorfolkHorn => 1.3,
            OvineBreed.NorwegianDale => 1.4,
            OvineBreed.PolledDorset => 1.5,
            OvineBreed.Shropshire => 1.6,
            OvineBreed.SouthDown => 1.7,
            OvineBreed.Texel => 1.8,
            OvineBreed.WelshMountain => 1.9,
            OvineBreed.WelshWhite => 2,
            OvineBreed.WestFriesian => 2,
            OvineBreed.Yakima => 2.1,
            _ => 0.2
        };

        return price;
    }

    private static double GetBovinePrice(Bovine bovine)
    {
        // Calculate price for bovine by sex, bovine_base_price, and breed

        var price = BaseBovinePrice;

        price = adjustPriceBasedOnSex(bovine, price);

        price *= bovine.Breed switch
        {
            BovineBreed.Holstein => 1.1,
            BovineBreed.Jersey => 1.2,
            BovineBreed.Friesian => 1.3,
            BovineBreed.Ayrshire => 1.4,
            BovineBreed.Guernsey => 1.5,
            BovineBreed.Red => 1.6,
            BovineBreed.Brown => 1.7,
            BovineBreed.White => 1.8,
            BovineBreed.Black => 1.9,
            BovineBreed.HolsteinFriesian => 2,
            BovineBreed.HolsteinJersey => 2.1,
            BovineBreed.HolsteinGuernsey => 2.2,
            BovineBreed.HolsteinAyrshire => 2.3,
            BovineBreed.HolsteinRed => 2.4,
            BovineBreed.HolsteinBrown => 2.5,
            BovineBreed.HolsteinWhite => 2.6,
            BovineBreed.HolsteinBlack => 2.7,
            BovineBreed.FriesianJersey => 2.8,
            BovineBreed.FriesianGuernsey => 2.9,
            BovineBreed.FriesianAyrshire => 3,
            BovineBreed.FriesianRed => 3.1,
            BovineBreed.FriesianBrown => 3.2,
            BovineBreed.FriesianWhite => 3.3,
            BovineBreed.FriesianBlack => 3.4,
            BovineBreed.JerseyGuernsey => 3.5,
            BovineBreed.JerseyAyrshire => 3.6,
            BovineBreed.JerseyRed => 3.7,
            BovineBreed.JerseyBrown => 3.8,
            BovineBreed.JerseyWhite => 3.9,
            BovineBreed.JerseyBlack => 4,
            BovineBreed.GuernseyAyrshire => 4.1,
            BovineBreed.GuernseyRed => 4.2,
            BovineBreed.GuernseyBrown => 4.3,
            BovineBreed.GuernseyWhite => 4.4,
            BovineBreed.GuernseyBlack => 4.5,
            BovineBreed.AyrshireRed => 4.6,
            BovineBreed.AyrshireBrown => 4.7,
            BovineBreed.AyrshireWhite => 4.8,
            BovineBreed.AyrshireBlack => 4.9,
            BovineBreed.RedBrown => 5,
            BovineBreed.RedWhite => 5.1,
            BovineBreed.RedBlack => 5.2,
            BovineBreed.BrownWhite => 5.3,
            BovineBreed.BrownBlack => 5.4,
            BovineBreed.WhiteBlack => 5.5,
            _ => throw new ArgumentOutOfRangeException()
        };

        return price;
    }


    private static double adjustPriceBasedOnSex(Animal animal, double price)
    {
        if (animal.GetSex() == Sex.Male)
            price *= 1.1;
        else
            price *= 0.9;

        return price;
    }
}