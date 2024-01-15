

using System.Reflection;
Truck truck = new Truck("s");
truck.Print();


public class Truck : Vehicle
{

   

    public Truck(string make) : base(make)
    {
    }

    public override void Drive()
    {
       this.Print();
    }
}
public abstract class Vehicle
{
    public Vehicle(string make)
    {
        this.Make = make;
    }

    public string Make { get; set; }

    public void Print()
    {
        Console.WriteLine(Make);
    }

    public abstract void Drive();
   
}