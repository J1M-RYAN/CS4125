public class Person
{
    private static int statId;
    private static readonly List<Person> persons = new();

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;

        //Like this, everytime a new object of Person is created, the ID will be the id of the last created object +1
        ID = statId;
        statId++;

        //Everytime you create a new instance of this class, it will be added to the list
        persons.Add(this);
    }

    public int ID { get; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public static Person GetPersonById(int id)
    {
        foreach (var per in persons)
            if (per.ID == id)
                return per;
        return null;
    }

    public static List<Person> GetPersons()
    {
        return persons;
    }
}