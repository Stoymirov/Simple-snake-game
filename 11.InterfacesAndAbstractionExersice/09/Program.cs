using ExplicitInterfaces;

string command ="";
while ((command = Console.ReadLine()) != "End")
{
    string[] tokens = command.Split();
    IPerson person = new Citizen()
    {
        Name = tokens[0],
        Age = int.Parse(tokens[2])
    };

    IResident resident = new Citizen()
    {
        Name = tokens[0],
        Age = int.Parse(tokens[2]),
        countrey = tokens[1]

    };
    Console.WriteLine(person.GetName());
    Console.WriteLine(resident.GetName());


}