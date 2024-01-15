using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _05.Models
{
    public class Team
    {
		private string name;
		private readonly List<Player> players;

        public Team(string name)
        {
            Name = name;
            players = new List<Player>();
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

        public double Rating
        {
            get
            {
                if (players.Any())
                {
                    return players.Average(p => p.Stats);
                }

                return 0;
            }
        }

        public void AddPlayer(Player player) => players.Add(player);

        public void RemovePlayer(string playerName)
        {
            Player pl = players.Find(x => x.Name == playerName);
            if (pl is null)
            {
                throw new ArgumentException($"Player {playerName} is not in {Name} team.");
            }
            players.Remove(pl);
        }


    }
}
