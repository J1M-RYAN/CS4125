
namespace CS4125.Data;
public class AnimalFactory
{
    private static int _id;

    public static Animal CreateAnimal(string animalType, string breed)
    {
        switch (animalType)
        {
            case "Bull":
                return new Bull(_id++, DateTime.Now, (BovineBreed)Enum.Parse(typeof(BovineBreed), breed));
            case "Cow":
                return new Cow(_id++, DateTime.Now, (BovineBreed)Enum.Parse(typeof(BovineBreed), breed), 0);
            default:
                throw new ArgumentException("Animal type not found");
        }
    }

}