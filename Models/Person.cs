public class Person
{
    private string firstName, lastName;
    private int id;
    private static int statId;
    private static List<Person> persons = new List<Person>();
    public Person(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;

        //Like this, everytime a new object of Person is created, the ID will be the id of the last created object +1
        id = statId;
        statId++;

        //Everytime you create a new instance of this class, it will be added to the list
        persons.Add(this);

    }
    public static Person GetPersonById(int id)
    {
        foreach (Person per in persons)
        {
            if (per.ID == id)
                return per;
        }
        return null;
    }
    public int ID
    {
        get { return id; }
    }

    public static List<Person> GetPersons()
    {
        return persons;
    }
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
}