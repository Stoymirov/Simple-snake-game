namespace PersonInfo;

public class Citizen:IPerson,IBornable,IIdentifiable
{
    public Citizen(string name, int age)
    {
        Age = age;
        Name = name;
    }

    public Citizen(string name, int age, string id, string birthdate) : this(name, age)
    {
        Birthdate = birthdate;
        Id = id;
    }
    public string Name { get; }
    public int Age { get; }
    public string Birthdate { get; }
    public string Id { get; }
}

