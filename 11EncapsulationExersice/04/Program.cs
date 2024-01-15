using PizzaCalories;
try

{
string[] pizzaInput = Console.ReadLine().Split();
string[] doughtInput = Console.ReadLine().Split();
Dough dough = new(doughtInput[1], doughtInput[2], double.Parse(doughtInput[3]));
Pizza pizza = new Pizza(pizzaInput[1],dough);
string command = "";
while((command= Console.ReadLine()) != "END")
{
    string[] toppings = command.Split();
    Topping topping = new Topping(toppings[1], double.Parse(toppings[2]));
    pizza.Add(topping);
}

Console.WriteLine(pizza);

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}