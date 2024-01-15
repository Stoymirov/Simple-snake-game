using System.Diagnostics;
using Shoppingspree;

//Product pr = new Product("",1);
//Console.WriteLine(pr);

List<Product> products = new List<Product>();
List<Person> people= new List<Person>();
try


{
    string[] nameMoneyPair = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

    foreach (var s in nameMoneyPair)
    {
        string[] nameMoney = s.Split("=", StringSplitOptions.RemoveEmptyEntries);
        Person person = new Person(nameMoney[0], decimal.Parse(nameMoney[1]));
        people.Add(person);
    }

    string[] prductConstPairs = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

    foreach (var s in prductConstPairs)
    {
        string[] productCost = s.Split("=",StringSplitOptions.RemoveEmptyEntries);
        Product product = new Product(productCost[0], decimal.Parse(productCost[1]));
        products.Add(product);
    }



}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
    return;
}

string input;
while ((input = Console.ReadLine()) != "END")
{
    string[] personProduct = input.Split();
    Person person = people.Find(x => x.Name == personProduct[0]);
    Console.WriteLine(person.Add(new Product(personProduct[1], products.Find(x => x.Name == personProduct[1]).Cost)));
}

foreach (var person in people)
{
    Console.WriteLine(person);
}