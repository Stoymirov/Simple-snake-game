using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name,Dough dough)
        {
            toppings = new List<Topping>();
            Dough = dough;
            Name = name;
        }

        public Dough Dough
        {
            get => dough;
            private set => dough = value;
        }


        public string Name
        {
            get => name;
            set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }

        }
        public int TopicNumber =>toppings.Count;

        public double TotalCal => TotalCalMethod();

        private double TotalCalMethod()
        {
            double totalCal = 0;
            foreach (var topping in toppings)
            {
                totalCal += topping.Calories;
            }

            totalCal += dough.TotalCal;
            return totalCal;
        }

        public void Add(Topping topping)
        {
            if (toppings.Count == 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            toppings.Add(topping);
        }
        public override string ToString()
        {
            return $"{Name} - {TotalCal:f2} Calories.";
        }
    }
}
