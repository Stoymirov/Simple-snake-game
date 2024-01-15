using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PizzaCalories
{
    public class Dough
    {
        private const int baseCalGram = 2;
        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(string type, string bakingTechnique, double weight)
        {
            FlourType = type;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }

        public double TotalCal => TotalCalMethod();
        
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value < 0 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }
        public string BakingTechnique
        {
            get => bakingTechnique;
            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                bakingTechnique = value;
            }
        }
        public string FlourType
        {
            get => flourType;
            set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                flourType = value;
            }
        }

        private double TotalCalMethod()
        {
            double calories = baseCalGram*weight;
            switch (flourType.ToLower())
            {
                case "white":
                    calories *= 1.5;
                    break;
                case "wholegrain":
                    calories *= 1;
                    break;

            }

            switch (bakingTechnique.ToLower())
            {
                case "crispy":
                    calories *= 0.9;
                    break;
                case "chewy":
                    calories *= 1.1;
                    break;
                case "homemade":
                    calories *= 1;
                    break;
            }

            return calories;
        }
    }
}
    
