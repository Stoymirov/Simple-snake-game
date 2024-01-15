using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _05.Models
{
    public class Player
    {
        private const string StartPropertyExceptionMessage = "{0} should be between 0 and 100.";
        private const int StatMinValue = 0;
        private const int StatMaxValue = 100;

        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name,int endurance,int sprint, int dribble, int passing, int shooting)
        {
            Endurance = endurance;
            Passing = passing;
            Sprint = sprint;
            Dribble = dribble;
            Shooting = shooting;
            Name = name;
        }
        public int Endurance
        {
            get { return endurance; }
            private set
            {
                if (value < StatMinValue || value > StatMaxValue)
                {
                    throw new ArgumentException(string.Format(StartPropertyExceptionMessage, nameof(Endurance)));
                }
                endurance = value;
            }
        }
        public int Sprint
        {
            get { return sprint; }
            private set
            {
                if (value < StatMinValue || value > StatMaxValue)
                {
                    throw new ArgumentException(string.Format(StartPropertyExceptionMessage, nameof(Sprint)));
                }
                sprint = value;
            }
        }
        public int Dribble
        {
            get { return dribble; }
            private set
            {
                if (value < StatMinValue || value > StatMaxValue)
                {
                    throw new ArgumentException(string.Format(StartPropertyExceptionMessage, nameof(Dribble)));
                }
                dribble = value;
            }
        }
        public int Shooting
        {
            get { return shooting; }
            private set
            {
                if (value < StatMinValue || value > StatMaxValue)
                {
                    throw new ArgumentException(string.Format(StartPropertyExceptionMessage, nameof(Shooting)));
                }
                shooting = value;
            }
        }
        public int Passing
        {
            get { return passing; }
            private set
            {
                if (value < StatMinValue || value > StatMaxValue)
                {
                    throw new ArgumentException(string.Format(StartPropertyExceptionMessage, nameof(Passing)));
                }
                passing = value;
            }
        }


        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("A name should not be empty.");
                }
                name = value;
            }
        }

        public double Stats => (Endurance + Dribble + Shooting + Sprint + Passing) / 5.0;

    }
}
