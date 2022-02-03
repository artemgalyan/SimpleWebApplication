namespace WebApplicationExample;

public class Person
{
    private static int _idCounter = 0;
    public string PhoneNumber { get; }
    public string Name { get; }
    public int Id { get; }

    public Person(string name, string phoneNumber = "unknown")
    {
        Name = name;
        ++_idCounter;
        Id = _idCounter;
        PhoneNumber = phoneNumber;
    }
}