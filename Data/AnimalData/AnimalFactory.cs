namespace CS4125.Data.AnimalData;

public class AnimalFactory
{
    private static int _id=19192363;

    public static Animal CreateAnimal(string animalType, string breed)
    {
        return animalType switch
        {
            "Bull" => new Bull(_id++, DateTime.Now, (BovineBreed) Enum.Parse(typeof(BovineBreed), breed)),
            "Cow" => new Cow(_id++, DateTime.Now, (BovineBreed) Enum.Parse(typeof(BovineBreed), breed), 0),
            "Stallion" => new Stallion(_id++, DateTime.Now, (EquineBreed) Enum.Parse(typeof(EquineBreed), breed)),
            "Mare" => new Mare(_id++, DateTime.Now, (EquineBreed) Enum.Parse(typeof(EquineBreed), breed), false),
            "Ram" => new Ram(_id++, DateTime.Now, (OvineBreed) Enum.Parse(typeof(OvineBreed), breed), 0),
            "Ewe" => new Ewe(_id++, DateTime.Now, (OvineBreed) Enum.Parse(typeof(OvineBreed), breed), 0),
            _ => throw new ArgumentException("Animal type not found")
        };
    }
}