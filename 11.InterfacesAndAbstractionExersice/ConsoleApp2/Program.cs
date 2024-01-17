using System.Security.Cryptography.X509Certificates;

namespace PersonInfo;

public class StartUp
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string id = Console.ReadLine();
        string birthdate = Console.ReadLine();
        IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
        IBornable bornable = new Citizen(name, age, id, birthdate);
        Console.WriteLine(identifiable.Id);
        Console.WriteLine(bornable.Birthdate);
        


    }
}