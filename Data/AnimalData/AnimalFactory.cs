namespace CS4125.Data.AnimalData;

public class AnimalFactory
{
    private static int _id;

    public static Animal CreateAnimal(string animalType, string breed)
    {
        switch (animalType)
        {
            case "Bull":
                return new Bull(_id++, DateTime.Now, (BovineBreed) Enum.Parse(typeof(BovineBreed), breed));
            case "Cow":
                return new Cow(_id++, DateTime.Now, (BovineBreed) Enum.Parse(typeof(BovineBreed), breed), 0);
            case "Stallion":
                return new Stallion(_id++, DateTime.Now, (EquineBreed) Enum.Parse(typeof(EquineBreed), breed));
            case "Mare":
                return new Mare(_id++, DateTime.Now, (EquineBreed) Enum.Parse(typeof(EquineBreed), breed), false);
            case "Ram":
                return new Ram(_id++, DateTime.Now, (OvineBreed) Enum.Parse(typeof(OvineBreed), breed), 0);
            case "Ewe":
                return new Ewe(_id++, DateTime.Now, (OvineBreed) Enum.Parse(typeof(OvineBreed), breed), 0);
            default:
                throw new ArgumentException("Animal type not found");
        }
    }
}